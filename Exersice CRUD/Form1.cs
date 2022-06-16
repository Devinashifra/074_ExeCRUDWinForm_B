using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exersice_CRUD
{
    public partial class Form1 : Form
    {
        Form2 Tampil;
        void Tampil_FormClosed(Object sender, FormClosedEventArgs e)
        {
            Tampil = null;
        }

        SqlConnection con = new SqlConnection("data source = LAPTOP-OEG29RPO\\DEVINAS;database = KOPISINI; User " +
                    "ID = sa; Password = Desember7");
        public Form1()
        {
            InitializeComponent();
        }
        String Jenis;
        SqlCommand cmd;

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (Tampil == null)
            {
                Tampil = new Form2();
                Tampil.FormClosed += new FormClosedEventHandler(Tampil_FormClosed);
                Tampil.Show();
            }
            else
            {
                Tampil.Activate();
            }
            this.Hide();

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Kopisini(Jenis, Jumlah_Pelanggan, Makanan, Jumlah_Makanan,Harga_Makanan, Minuman, Jumlah_Minuman, Harga_Minuman, Total, Bayar, Kembalian) values ('"+Jenis+"','"+txjumlahpel.Text+"','"+txmakanan.Text+"','"+txjumlahmakan.Text+"','"+txhargamakan.Text+"','"+txminuman.Text+"','"+txhargaminum.Text+"','"+txjumlahminum.Text+"','"+txtotal.Text+"','"+txbayar.Text+"','"+txkembalian.Text+"')";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbdinein_CheckedChanged(object sender, EventArgs e)
        {
            Jenis = "Dine In";
        }

        private void cbtakeaway_CheckedChanged(object sender, EventArgs e)
        {
            Jenis = "Take Away";
        }
    }
}
