using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ARMS.Dao
{
    class SpecDbDao
    {
        MySqlConnection conn;
        String queryForm;
        Model.RecipeParam param;

        public SpecDbDao()
        {
            this.param = new Model.RecipeParam();
            StringBuilder _strArg = new StringBuilder();
            _strArg.Append("Server=");
            _strArg.Append("10.21.11.210");
            _strArg.Append(";Port=");
            _strArg.Append("3306");
            _strArg.Append(";Database = ");
            _strArg.Append("recipe");          // 데이터베이스
            _strArg.Append(";Uid = ");
            _strArg.Append("aoi");                     // ID
            _strArg.Append(";Pwd = ");
            _strArg.Append("abc123**");                 // PWD
            _strArg.Append(";");

            try
            {
                conn = new MySqlConnection(_strArg.ToString());
                this.queryForm =
                            @"SELECT
	                            a.cluster_recipe
	                            , a.frontside_recipe
	                            , a.inspection_dies
	                            , a.inspection_columns
	                            , a.inspection_rows
                            FROM 
	                            recipe.spec a
                            WHERE 1 = 1
                                AND a.cluster_recipe like '{0}%';";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public Model.RecipeParam getRecipeParam(String clusterRecipe)
        {
            if (clusterRecipe != "")
            {
                String query = String.Format(this.queryForm, clusterRecipe);
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        param.setClusterRecipe(rdr["cluster_recipe"].ToString());
                        param.setFrontsideRecipe(rdr["frontside_recipe"].ToString());
                        param.setInspectionDies(rdr["inspection_dies"].ToString());
                        param.setInsepctionColumns(rdr["inspection_columns"].ToString());
                        param.setInspectionRows(rdr["inspection_rows"].ToString());
                        return param;
                    }
                    else
                    {
                        return param;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return new Model.RecipeParam();
                }
            }
            else
            {
                return new Model.RecipeParam();
            }
        }
    }
}
