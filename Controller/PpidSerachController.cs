using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ARMS.Controller
{
    class PpidSearchController
    {
        MySqlConnection conn;
        String queryForm;

        public event EventHandler<DataTable> GetPpid;


        public PpidSearchController()
        {

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
	                            p.ppid
                            FROM
	                            recipe.ppid p
                            WHERE
	                            1 = 1
                            	AND p.ppid LIKE '{0}%'";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void getPPID(String clusterRecipe)
        {
            DataTable resultTable = new DataTable();
            if (clusterRecipe != "")
            {
                String query = String.Format(this.queryForm, clusterRecipe);
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(resultTable);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    conn.Close();
                }
            }
            if (GetPpid != null)
            {
                GetPpid(this, resultTable);
            }
        }
    }
}
