using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Model;
using MySql.Data.MySqlClient;


namespace ARMS.Repository
{
    class PpidRepository
    {
        MySqlConnection conn;
        
        public ArrayList FindAllPpid()
        {
            ArrayList Ppids = new ArrayList();

            conn = new DBConnectorFactory().getConnection();
            string query = "SELECT * FROM recipe.ppid";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();

            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                RecipePpid ppid = new RecipePpid()
                {
                    Ppid = rdr["ppid"].ToString(),
                    Device = rdr["Device"].ToString()
                };
                Ppids.Add(ppid);
            }
            rdr.Close();
            conn.Close();
            return Ppids;
        }
        
        public ArrayList FindByDevice(string device)
        {
            ArrayList Ppids = new ArrayList();
            conn = new DBConnectorFactory().getConnection();
            string query = $"SELECT * FROM recipe.ppid WHERE ppid.device = '{device}'";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                RecipePpid ppid = new RecipePpid()
                {
                    Ppid = rdr["ppid"].ToString(),
                    Device = rdr["Device"].ToString()
                };
                Ppids.Add(ppid);
            }
            rdr.Close();
            conn.Close();
            return Ppids;
        }
    }
}
