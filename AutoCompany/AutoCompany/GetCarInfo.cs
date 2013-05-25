using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using System.Data;

namespace AutoCompany
{
    public class GetCarInfo
    {
        public string oradb;

        public GetCarInfo()
        {
             oradb = "Data Source=(DESCRIPTION="
             + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
             + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));"
             + "User Id=DBA_20122013L_GRP_028;Password=8244442;";
        }
        public List<String> make_connection()
        {
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            string selectStmt = string.Format("select car.*, mar.IMENAMARKA from VOZILA car, MODELI mod, MARKA mar where car.IMENAMODEL = mod.IMENAMODEL and mod.IMENAMARKA = mar.IMENAMARKA ");

            OracleCommand cmd = new OracleCommand(selectStmt, conn);
            OracleDataReader dataReader = cmd.ExecuteReader();

            List<String> redovi = new List<string>();
            while (dataReader.Read())
            {
                string temp = dataReader.GetString(1).ToString() + " ";
                temp = temp + dataReader.GetString(16).ToString() + " ";
                temp = temp + dataReader.GetString(15).ToString() + " ";
                temp = temp + dataReader.GetValue(2).ToString() + " ";
                temp = temp + dataReader.GetValue(3).ToString() + " ";
                temp = temp + dataReader.GetValue(4).ToString() + " ";
                temp = temp + dataReader.GetValue(5).ToString() + " ";
                temp = temp + dataReader.GetValue(6).ToString() + " ";
                temp = temp + dataReader.GetValue(7).ToString() ;
               

                redovi.Add(temp);
            }
            

            conn.Close();
            conn.Dispose();
           
            return redovi;

        }

    }
}
