using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;

namespace AutoCompany
{
    public class ReadSales
    {
        public string oradb;

        public ReadSales()
        {
            oradb = "Data Source=(DESCRIPTION="
            + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));"
            + "User Id=DBA_20122013L_GRP_028;Password=8244442;";
        }
        public void Read()
        {
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            string selectStmt = string.Format("select  p.brdogovor as Договор, p.DATANADOGOVOR as Дата, p.CENANADOGOVOR as Цена, m.IMENAMARKA as Марка, mod.Imenamodel as Модел, l.ime || ' ' || l.prezime as Вработен , s.ime || ' ' || s.prezime as Клиент from Prodazba p , Klienti k, luge l,luge s, vraboteni v, vozila c ,Marka m , modeli mod where s.embg=k.embg and k.embg=p.kembg and l.embg=v.embg and v.embg=p.sembg and p.BRDOGOVOR=c.BRDOGOVOR and mod.IMENAMODEL=c.IMENAMODEL and mod.imenamarka=m.imenamarka");
            OracleCommand cmd = new OracleCommand(selectStmt, conn);
            OracleDataReader dataReader = cmd.ExecuteReader();
            
        }
    }
}
