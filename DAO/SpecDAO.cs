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
        Entity entity;
        String queryForm;
        private static readonly ILog log = LogManager.GetLogger("ARMS/S2F41 DB Finder");
        public SpecDAO()
        {
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
                                AND a.cluster_recipe ='{0}';";

            }catch(Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }
        }

        public Entity selectQuery(String clusterRecipe)
        {

            String query = String.Format(this.queryForm, clusterRecipe);
            log.Info($"SELECT query : \n\t\t {query}");
            DataTable specParams = new DataTable();

            try
            {
                MySqlDataAdapter adt = new MySqlDataAdapter(query, conn);
                log.Info("SELECT query SUCC");
                adt.Fill(specParams);

            }
            catch(Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }

            if (specParams.Rows.Count == 0)
            {

                return new Entity();
            }
            else
            {

                entity = new Entity(
                    specParams.Rows[0][0].ToString(),
                    specParams.Rows[0][1].ToString(),
                    specParams.Rows[0][2].ToString(),
                    specParams.Rows[0][3].ToString(),
                    specParams.Rows[0][4].ToString()
                    );

                return entity;
            }
        }
    }
}
