using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;
using System.Data;

namespace ARMS
{
    // ※ RCMD 확인하기
    //      │
    //      ├─ RCMD != "RECIPE_CHECK"
    //      │    └─ S2F41 Message Reply
    //      │        └─ S2F42 Message(HACK 1)
    //      │
    //      └─ RCMD == "REICPE_CHECK"
    //          └─ S2F41 Message Reply
    //              ├─ S2F42 Message(HACK 0)
    //              └─ ※ SPEC Recipe 비교하기
    //                      │
    //                      ├─ ※ SPEC DB 연결
    
    class S2F41Receiver:S2F41ReceiverInterface
    {
        String RCMD;
        PrimaryMessageWrapper pMsg;


        public S2F41Receiver(PrimaryMessageWrapper pMsg)
        {
            this.pMsg = pMsg;
            RCMD = getRCMD();
        }

        public bool checkRCMD()
        {
            if(RCMD == "RECIPE_CHECK") // conf value store에서 가져와서 확인 해야함
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


        public string getRCMD()
        {
            return pMsg.Message.SecsItem.Items[0].GetValue<String>();
        }

        public void replyS2F42(bool flag)
        {
            if (flag)
            {
                // S2F42 HACK 0 보내기
            }
            else
            {
                // S2F42 HACK 1 보내기
            }
        }

        public DataTable getParams()
        {
            // items = [cluster recipe, frontside recipe, inspection dies, row dies, column dies]
            DataTable recipeParmas = new DataTable();
            
            Item items = pMsg.Message.SecsItem.Items[1].Items[0].Items[3];

            recipeParmas.Columns.Add("cluster_recipe", typeof(string));
            recipeParmas.Columns.Add("frontside_recipe", typeof(string));
            recipeParmas.Columns.Add("inspection_dies", typeof(string));
            recipeParmas.Columns.Add("inspection_columns", typeof(string));
            recipeParmas.Columns.Add("inspection_rows", typeof(string));

            DataRow row = recipeParmas.NewRow();
            row["cluster_recipe"] = pMsg.Message.SecsItem.Items[1].Items[0].Items[0].GetValue<String>();
            foreach(Item item in items.Items)
            {
                if (item.Items[0] == "Frontside/RecipeName") row["frontside_recipe"] = item.Items[1].Items[0].GetValue<String>();
                if (item.Items[0] == "Frontside/TestableDies") row["inspection_dies"] = item.Items[1].Items[0].GetValue<String>();
                if (item.Items[0] == "Frontside/ColumnNumber") row["inspection_columns"] = item.Items[1].Items[0].GetValue<String>();
                if (item.Items[0] == "Frontside/RowNumber") row["inspection_rows"] = item.Items[1].Items[0].GetValue<String>();
            }

            recipeParmas.Rows.Add(row);
            return recipeParmas;

        }

    }
}
