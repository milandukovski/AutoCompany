using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;

namespace AutoCompany
{
    public class AddCar
    {
        public string oradb;

        public AddCar()
        {
             oradb = "Data Source=(DESCRIPTION="
            + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));"
            + "User Id=DBA_20122013L_GRP_028;Password=8244442;";
        }
        public void add()
        {
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            string sqlIns = "INSERT INTO VOZILA (VOZILOID,SLIKA) VALUES (@VOZILOID,@SLIKA)";
            OracleCommand insert = new OracleCommand("INSERT INTO VOZILA (VOZILOID,SLIKA) VALUES (1,'123')", conn);
            insert.ExecuteNonQuery();
            conn.Dispose();
            conn.Close();
        }
        public void add(string pic,int weight, int gorivo,int year,string dimenz, int topSpeed,int price, string model)
        {
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();

//++++++++++++++++++++++++++++ VOZILOID ++++++++++++++++++++++++++++
            OracleCommand voziloID = new OracleCommand("select max(voziloid) from vozila", conn);
            OracleDataReader rd = voziloID.ExecuteReader(); rd.Read();
            String vzID = rd.GetValue(0).ToString();
            int ID = int.Parse(vzID)+1;


            
            string sqlIns = "INSERT INTO VOZILA  VALUES (";
            sqlIns += ID.ToString() + ",";
            sqlIns += "'"+pic+"'" + ",";
            sqlIns += weight.ToString() + ",";
            sqlIns += gorivo.ToString() + ",";
            sqlIns += year.ToString() + ",";
            sqlIns += "'"+ dimenz + "',";
            sqlIns += topSpeed.ToString()+",";
            sqlIns += price.ToString() + ",";
            sqlIns += "'DA','NE','NE',";
            sqlIns += "9003,";
            sqlIns += "1,";
            sqlIns += "'FINKI-MOTORS',";
            sqlIns += "null,";
            sqlIns += "'"+model + "')";
            
            OracleCommand insert = new OracleCommand(sqlIns, conn);
            insert.ExecuteNonQuery();
            conn.Dispose();
            conn.Close();
        }
    }
}
