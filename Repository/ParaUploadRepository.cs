﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Model;
using Secs4Net;
using MySql.Data.MySqlClient;

namespace ARMS.Repository
{
    class ParaUploadRepository
    {
        readonly RecipeParam param;
        readonly PrimaryMessageWrapper pMsg;
        MySqlConnection conn;

        public ParaUploadRepository(PrimaryMessageWrapper pMsg)
        {
            param = new RecipeParam();
            this.pMsg = pMsg;
            conn = new DBConnectorFactory().getConnection();
        }

        public RecipeParam GetRecipeParam()
        {
            Item items = pMsg.Message.SecsItem.Items[1].Items[0].Items[3];
            param.ClusterRecipe = pMsg.Message.SecsItem.Items[1].Items[0].Items[0].GetValue<String>();
            foreach (var item in items.Items)
            {
                if (item.Items[0] == "Frontside\\RecipeName")
                {
                    param.FrontsideRecipe = item.Items[1].Items[0].GetValue<string>();
                }
                if (item.Items[0] == "Frontside\\TestableDies")
                {
                    param.InspectionDies = item.Items[1].Items[0].GetValue<string>();
                }
                if (item.Items[0] == "Frontside\\ColumnNumber")
                {
                    param.InspectionColumns = item.Items[1].Items[0].GetValue<string>();
                }
                if (item.Items[0] == "Frontside\\RowNumber")
                {
                    param.InspectionRows = item.Items[1].Items[0].GetValue<string>();
                }
            }
            return param;
        }
        public SecsMessage S2F42()
        {
            S2F42 s2f42 = new S2F42
            {
                HCACK = 0
            };

            return s2f42.Message;
        }

        public void DBUploadParam(RecipeParam param)
        {
            string queryForm =
                @"INSERT INTO recipe.spec
                    (cluster_reicpe,
                    frontside_recipe,
                    inspection_dies,
                    inspection_columns,
                    inspeciton_rows)
                Values(
                    '{0}', '{1}', '{2}', '{3}', '{4}');";
            string query = string.Format(queryForm,
                param.ClusterRecipe,
                param.FrontsideRecipe,
                int.Parse(param.InspectionDies),
                int.Parse(param.InspectionColumns),
                int.Parse(param.InspectionRows));
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                Console.WriteLine("Inser Succ");
            }
        }
    }
}
