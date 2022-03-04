using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;

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

        public List<String> getParams()
        {
            // items = [cluster recipe, frontside recipe, inspection dies, row dies, column dies]
            List<String> recipeParams = new List<String>();

            recipeParams.Append<String>(pMsg.Message.SecsItem.Items[1].Items[0].Items[1].GetValue<String>()); // Cluster Recipe

            Item items = pMsg.Message.SecsItem.Items[1].Items[0].Items[3];
            foreach (Item item in items.Items)
            {
                if (item.Items[0].GetValue<String>() == "Frontside/RecipeName")
                {
                    recipeParams.Append<String>(item.Items[0].GetValue<String>());
                
                }
                if (item.Items[0].GetValue<String>() == "Frontside/TestableDies")
                {
                    recipeParams.Append<String>(item.Items[0].GetValue<String>());
                }

                if (item.Items[0].GetValue<String>() == "Frontside/RowNumber")
                {
                    recipeParams.Append<String>(item.Items[0].GetValue<String>());
                }

                if (item.Items[0].GetValue<String>() == "Frontside/ColumnNumber")
                {
                    recipeParams.Append<String>(item.Items[0].GetValue<String>());
                }
            }
            return recipeParams;

        }

    }
}
