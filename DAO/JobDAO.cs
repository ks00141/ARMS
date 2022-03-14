using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;
using ARMS.Model;
using System.Data;

namespace ARMS.DAO
{
    class JobDAO
    {
        Entity entity;
        DataTable recipeParams;

        public JobDAO()
        {


            recipeParams = new DataTable();

            recipeParams.Columns.Add("cluster_recipe", typeof(string));
            recipeParams.Columns.Add("frontside_recipe", typeof(string));
            recipeParams.Columns.Add("inspection_dies", typeof(string));
            recipeParams.Columns.Add("inspection_columns", typeof(string));
            recipeParams.Columns.Add("inspection_rows", typeof(string));

        }

        public Entity selectQuery(PrimaryMessageWrapper pMsg)
        {
            Item items = pMsg.Message.SecsItem.Items[1].Items[0].Items[3];

            DataRow row = recipeParams.NewRow();
            row["cluster_recipe"] = pMsg.Message.SecsItem.Items[1].Items[0].Items[0].GetValue<String>();
            foreach (Item item in items.Items)
            {
                if (item.Items[0] == "Frontside/RecipeName") row["frontside_recipe"] = item.Items[1].Items[0].GetValue<String>();
                if (item.Items[0] == "Frontside/TestableDies") row["inspection_dies"] = item.Items[1].Items[0].GetValue<String>();
                if (item.Items[0] == "Frontside/ColumnNumber") row["inspection_columns"] = item.Items[1].Items[0].GetValue<String>();
                if (item.Items[0] == "Frontside/RowNumber") row["inspection_rows"] = item.Items[1].Items[0].GetValue<String>();
            }

            recipeParams.Rows.Add(row);

            entity = new Entity(
                recipeParams.Rows[0][0].ToString(),
                recipeParams.Rows[0][1].ToString(),
                recipeParams.Rows[0][2].ToString(),
                recipeParams.Rows[0][3].ToString(),
                recipeParams.Rows[0][4].ToString()
                );


            return entity;
        }
        
    }
}
