using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Model;
using MySql.Data.MySqlClient;
using System.Data;


namespace ARMS.DAO
{
    class SpecDAO
    {
        MySqlConnection conn;
        Entity entity;
        String queryForm;
        public SpecDAO()
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
        }

        public Entity selectQuery(String clusterRecipe)
        {
            String query = String.Format(this.queryForm, clusterRecipe);
            MySqlDataAdapter adt = new MySqlDataAdapter(query, conn);
            DataTable specParams = new DataTable();
            adt.Fill(specParams);

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
