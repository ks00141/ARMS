using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ARMS
{
    class DBConnectorFactory
    {
        

        public MySqlConnection getConnection()
        {

            return new MySqlConnection(dbArg());
        }

        public String dbArg()
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
            return _strArg.ToString();
        }
    }
}
