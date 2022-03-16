using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using log4net;
using System.Reflection;

namespace ARMS
{
    class DBConnectorFactory
    {
        private static readonly ILog log = LogManager.GetLogger("ARMS/DBConnection Factory");


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
            log.Info($"DB Connection info - Server=10.21.11.210");
            log.Info($"DB Connection info - Port=3306");
            log.Info($"DB Connection info - Database=recipe");
            log.Info($"DB Connection info - Uid=aoi");
            log.Info($"DB Connection info - Pwd=***********");
            return _strArg.ToString();
        }
    }
}
