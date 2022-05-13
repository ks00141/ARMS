using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Model;
using Secs4Net;
using MySql.Data.MySqlClient;

namespace ARMS.Repository
{
    class ParaUploadDbRepository
    {
        readonly RecipeParam param;
        MySqlConnection conn;

        public ParaUploadDbRepository()
        {
            param = new RecipeParam();
            conn = new DBConnectorFactory().getConnection();
        }

        public void DBParamUpload(RecipeParam param)
        {
            string queryForm =
                @"INSERT INTO recipe.spec
                    (cluster_recipe,
                    frontside_recipe,
                    inspection_dies,
                    inspection_columns,
                    inspection_rows)
                VALUES(
                    '{0}', '{1}', '{2}', '{3}', '{4}')
                ON
                    duplicate
                KEY UPDATE
                    modify_date = CURDATE();";
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
                Console.WriteLine("Insert Succ");
                Console.WriteLine(param.ClusterRecipe);
                Console.WriteLine(param.FrontsideRecipe);
                Console.WriteLine(param.InspectionDies);
                Console.WriteLine(param.InspectionColumns);
                Console.WriteLine(param.InspectionRows);
            }
        }
    }
}
