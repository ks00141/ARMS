using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Model;
using MySql.Data.MySqlClient;
using System.Data;
using log4net;
using System.Reflection;


namespace ARMS.DAO
{
    class SpecDAO
    {
        MySqlConnection conn;
        RecipeParam entity;
        String queryForm;
        private static readonly ILog log = LogManager.GetLogger("ARMS/S2F41 DB Finder");
        public SpecDAO()
        {
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
                            AND a.cluster_recipe ='{0}';";
        }

        public RecipeParam selectQuery(String clusterRecipe)
        {

            /*String query = String.Format(this.queryForm, clusterRecipe);
            log.Info($"SELECT query : \n\t\t {query}");
            DataTable specParams = new DataTable();

            MySqlDataAdapter adt = new MySqlDataAdapter(query, conn);
            log.Info("SELECT query SUCC");
            adt.Fill(specParams);

            if (specParams == null || specParams.Rows.Count == 0)
            {
                log.Debug("query result none");
                return new RecipeParam();
            }
            else
            {
                entity = new RecipeParam(
                    specParams.Rows[0][0].ToString(),
                    specParams.Rows[0][1].ToString(),
                    specParams.Rows[0][2].ToString(),
                    specParams.Rows[0][3].ToString(),
                    specParams.Rows[0][4].ToString()
                    );

                return entity;
            }*/
            this.entity = new RecipeParam();
            if (clusterRecipe != "")
            {
                conn = new DBConnectorFactory().getConnection();
                String query = String.Format(this.queryForm, clusterRecipe);
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        entity.setClusterRecipe(rdr["cluster_recipe"].ToString());
                        log.Info($"SPEC Cluster : {rdr["cluster_recipe"].ToString()}");
                        entity.setFrontsideRecipe(rdr["frontside_recipe"].ToString());
                        log.Info($"SPEC Frontside : {rdr["frontside_recipe"].ToString()}");
                        entity.setInspectionDies(rdr["inspection_dies"].ToString());
                        log.Info($"SPEC Inspection Dies : {rdr["inspection_dies"].ToString()}");
                        entity.setInsepctionColumns(rdr["inspection_columns"].ToString());
                        log.Info($"SPEC Inspection Columns : {rdr["inspection_columns"].ToString()}");
                        entity.setInspectionRows(rdr["inspection_rows"].ToString());
                        log.Info($"SPEC Inspection Rows : {rdr["inspection_rows"].ToString()}");
                        rdr.Close();
                        conn.Close();
                        return entity;
                    }
                    else
                    {
                        rdr.Close();
                        conn.Close();
                        return entity;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    conn.Close();
                    return entity;
                }
            }
            else
            {
                return entity;
            }
        }
    }
}
