using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;

namespace AutoCompany
{
    public class LoginTo
    {
        public string oradb;
        public Dictionary<int, string> logInfo;
        public LoginTo()
        {
             oradb = "Data Source=(DESCRIPTION="
             + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
             + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));"
             + "User Id=DBA_20122013L_GRP_028;Password=8244442;";
             logInfo = new Dictionary<int, string>();
        }
       // select s.STAFFID, l.ime from VRABOTENI s, LUGE l where s.embg=l.embg
        public bool LogIn(string name, int pass)
        {
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            string selectStmt = string.Format("select s.STAFFID, l.ime from VRABOTENI s, LUGE l where s.embg=l.embg");

            OracleCommand cmd = new OracleCommand(selectStmt, conn);
            OracleDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                double ID = dataReader.GetDouble(0);
                string user = dataReader.GetString(1).Trim();
                if (ID == pass && user.Equals(name)) return true;
            }

            return false;
        }
    }
}
