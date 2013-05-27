using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace AutoCompany
{
    public partial class StaffInterface : Form
    {
        public string user;
        public int pass;
        public StaffInterface()
        {
            InitializeComponent();
            TABLE.Visible = false;
         }
        public void setUserPass(string  us, int pa)
        {
            user = us;
            pass = pa;
            label2.Text = user;
        }

        private void CatalogBtn_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.ShowDialog();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            ClearBtn.Visible = true;
            TABLE.DataSource = null;
            string oradb = "Data Source=(DESCRIPTION="
             + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
             + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));"
             + "User Id=DBA_20122013L_GRP_028;Password=8244442;";

            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            string selectStmt = string.Format("select  p.brdogovor as dogovor , p.DATANADOGOVOR as Data , p.CENANADOGOVOR as Cena, m.IMENAMARKA as Marka, mod.Imenamodel as Model , l.ime , l.prezime , s.ime, s.prezime  from Prodazba p , Klienti k, luge l,luge s, vraboteni v, vozila c ,Marka m , modeli mod where s.embg=k.embg and k.embg=p.kembg and l.embg=v.embg and v.embg=p.sembg and p.BRDOGOVOR=c.BRDOGOVOR and mod.IMENAMODEL=c.IMENAMODEL and mod.imenamarka=m.imenamarka");
            OracleDataAdapter dataAdapter = new OracleDataAdapter(selectStmt, conn);
            OracleCommandBuilder cmb = new OracleCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            TABLE.DataSource = table;
            TABLE.Visible = true;

            conn.Close();
        }

        private void CheckServis_Click(object sender, EventArgs e)
        {
            ClearBtn.Visible = true;
            string oradb = "Data Source=(DESCRIPTION="
             + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
             + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));"
             + "User Id=DBA_20122013L_GRP_028;Password=8244442;";

            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            string selectStmt = string.Format("select  s.IMENASERVIS as Servis, l.ime, l.prezime, S.CENANASERVIS as Cena, m.IMENAMARKA as Marka, mod.IMENAMODEL as Model FROM  LUGE L, KLIENTI K, odinaservis odi, SERVIS s, vozila car, marka m, modeli mod where l.embg=k.embg and k.EMBG=odi.KEMBG and odi.servisid=s.servisid and s.VOZILOID=car.VOZILOID and  car.IMENAMODEL=mod.IMENAMODEL and m.IMENAMARKA=mod.IMENAMARKA ");
            OracleDataAdapter dataAdapter = new OracleDataAdapter(selectStmt, conn);
            OracleCommandBuilder cmb = new OracleCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            TABLE.DataSource = table;
            TABLE.Visible = true;

            conn.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearBtn.Visible = false;
            TABLE.DataSource = null;
            TABLE.Visible = false;
        }

        private void AddCarBtn_Click(object sender, EventArgs e)
        {
            CreateCar createCar = new CreateCar();
            createCar.logIn(user);
            createCar.ShowDialog();

        }
    }
}
