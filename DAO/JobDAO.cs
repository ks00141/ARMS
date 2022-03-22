using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;
using ARMS.Model;
using System.Data;
using log4net;
using System.Reflection;

namespace ARMS.DAO
{
    class JobDAO
    {
        Entity entity;
        DataTable recipeParams;
        private static readonly ILog log = LogManager.GetLogger("ARMS/S2F41 Message Parser");

        public JobDAO()
        {
            recipeParams = new DataTable();
            log.Info("DataTable Instance created");

            recipeParams.Columns.Add("cluster_recipe", typeof(string));
            log.Info("DataTable Column Add - cluster_recipe");
            recipeParams.Columns.Add("frontside_recipe", typeof(string));
            log.Info("DataTable Column Add - frontside_recipe");
            recipeParams.Columns.Add("inspection_dies", typeof(string));
            log.Info("DataTable Column Add - inspection_dies");
            recipeParams.Columns.Add("inspection_columns", typeof(string));
            log.Info("DataTable Column Add - inspection_columns");
            recipeParams.Columns.Add("inspection_rows", typeof(string));
            log.Info("DataTable Column Add - inspection_rows");

        }

        public Entity parseMsg(PrimaryMessageWrapper pMsg)
        {
            Item items = pMsg.Message.SecsItem.Items[1].Items[0].Items[5];
            log.Info($"Count of Primary Msg Items : {items.Count}");

            DataRow row = recipeParams.NewRow();
            row["cluster_recipe"] = pMsg.Message.SecsItem.Items[1].Items[0].Items[2].GetValue<String>();
            log.Info($"cluster_recipe column insert data : {row["cluster_recipe"]}");
            foreach (Item item in items.Items)
            {
                if (item.Items[0] == "Frontside\\RecipeName")
                {
                    row["frontside_recipe"] = item.Items[1].Items[0].GetValue<String>();
                    log.Info($"frontside_recipe column insert data : {row["frontside_recipe"]}");
                }
                if (item.Items[0] == "Frontside\\TestableDies")
                {
                    row["inspection_dies"] = item.Items[1].Items[0].GetValue<String>();
                    log.Info($"inspection_dies column insert data : {row["inspection_dies"]}");
                }
                if (item.Items[0] == "Frontside\\ColumnNumber")
                {
                    row["inspection_columns"] = item.Items[1].Items[0].GetValue<String>();
                    log.Info($"inspection_columns column insert data : {row["inspection_columns"]}");
                }
                if (item.Items[0] == "Frontside\\RowNumber")
                {
                    row["inspection_rows"] = item.Items[1].Items[0].GetValue<String>();
                    log.Info($"inspection_rows column insert data : {row["inspection_rows"]}");
                }

            }

            recipeParams.Rows.Add(row);
            if (recipeParams.Rows.Count == 0)
            {
                log.Debug("SECS/GEM Message parsing failed");
                return new Entity();
            }
            else
            {
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
}
