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
            try
            {
                conn = new DBConnectorFactory().getConnection();
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
                        param.ClusterRecipe = rdr["cluster_recipe"].ToString();
                        param.FrontsideRecipe = rdr["frontside_recipe"].ToString();
                        param.InspectionDies = rdr["inspection_dies"].ToString();
                        param.InspectionColumns = rdr["inspection_columns"].ToString();
                        param.InspectionRows = rdr["inspection_rows"].ToString();
                        conn.Close();
                        return param;
                    }
                    else
                    {
                        conn.Close();
                        return param;
                    }

                }
                catch (Exception e)
                {
                    conn.Close();
                    return new Model.RecipeParam();
                }
            }
            else
            {
                conn.Close();
                return new Model.RecipeParam();
            }
        }
    }
}
