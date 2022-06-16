using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersice_CRUD
{
    public partial class Form2 : Form
    {
        DataTable dt;
        DataRow dr;
        string jumlahpel;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kOPISINIDataSet.Kopisini' table. You can move, or remove it, as needed.
            this.kopisiniTableAdapter.Fill(this.kOPISINIDataSet.Kopisini);

        }

        private void btnsave2_Click(object sender, EventArgs e)
        {
            dt = kOPISINIDataSet.Tables["Kopisini"];
            dr = dt.NewRow();
            dr[0] = cbjenis2.SelectedItem;
            dr[1] = txjumlahpel2.Text;
            dr[2] = txmakanan2.Text;
            dr[3] = txjmlmakan2.Text;
            dr[4] = txhargamakan2.Text;
            dr[5] = txminum2.Text;
            dr[6] = txjmlminum2.Text;
            dr[7] = txhargaminum2.Text;
            dr[8] = txtotalmakan2.Text;
            dr[9] = txbayar2.Text;
            dr[10] = txkembali2.Text;
            dt.Rows.Add(dr);
            kopisiniTableAdapter.Update(kOPISINIDataSet);
            cbjenis2.Enabled = false;
            txjumlahpel2.Enabled = false;
            txmakanan2.Enabled = false;
            txjmlmakan2.Enabled = false;
            txhargamakan2.Enabled = false;
            txminum2.Enabled = false;
            txjmlminum2.Enabled = false;
            txhargaminum2.Enabled = false;
            txtotalmakan2.Enabled = false;
            txbayar2.Enabled = false;
            txkembali2.Enabled = false;
            this.kopisiniTableAdapter.Fill(this.kOPISINIDataSet.Kopisini);
            btndelete.Enabled = true;
            btnupdate.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string jumlahpel;
            jumlahpel = txjumlahpel2.Text;
            dr = kOPISINIDataSet.Tables["Kopisini"].Rows.Find(jumlahpel);
            dr.Delete();
            kopisiniTableAdapter.Update(kOPISINIDataSet);
        }
    }
}
