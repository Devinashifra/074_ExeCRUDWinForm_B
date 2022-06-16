
namespace Exersice_CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.judul = new System.Windows.Forms.Label();
            this.jenis = new System.Windows.Forms.Label();
            this.cbdinein = new System.Windows.Forms.CheckBox();
            this.cbtakeaway = new System.Windows.Forms.CheckBox();
            this.jumlahpelanggan = new System.Windows.Forms.Label();
            this.txjumlahpel = new System.Windows.Forms.TextBox();
            this.makanan = new System.Windows.Forms.Label();
            this.minuman = new System.Windows.Forms.Label();
            this.jumlahmakan = new System.Windows.Forms.Label();
            this.hargamakan = new System.Windows.Forms.Label();
            this.hargaminum = new System.Windows.Forms.Label();
            this.jumlahminum = new System.Windows.Forms.Label();
            this.txmakanan = new System.Windows.Forms.TextBox();
            this.txminuman = new System.Windows.Forms.TextBox();
            this.txjumlahmakan = new System.Windows.Forms.TextBox();
            this.txhargamakan = new System.Windows.Forms.TextBox();
            this.txjumlahminum = new System.Windows.Forms.TextBox();
            this.txhargaminum = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.txtotal = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.txbayar = new System.Windows.Forms.TextBox();
            this.bayar = new System.Windows.Forms.Label();
            this.txkembalian = new System.Windows.Forms.TextBox();
            this.kembalian = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.BackColor = System.Drawing.Color.Transparent;
            this.judul.Font = new System.Drawing.Font("Monotype Corsiva", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul.ForeColor = System.Drawing.Color.White;
            this.judul.Location = new System.Drawing.Point(327, 27);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(266, 67);
            this.judul.TabIndex = 1;
            this.judul.Text = "KOPISINI";
            // 
            // jenis
            // 
            this.jenis.AutoSize = true;
            this.jenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenis.ForeColor = System.Drawing.Color.White;
            this.jenis.Location = new System.Drawing.Point(75, 153);
            this.jenis.Name = "jenis";
            this.jenis.Size = new System.Drawing.Size(52, 22);
            this.jenis.TabIndex = 2;
            this.jenis.Text = "Jenis";
            // 
            // cbdinein
            // 
            this.cbdinein.AutoSize = true;
            this.cbdinein.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdinein.ForeColor = System.Drawing.Color.White;
            this.cbdinein.Location = new System.Drawing.Point(196, 149);
            this.cbdinein.Name = "cbdinein";
            this.cbdinein.Size = new System.Drawing.Size(92, 26);
            this.cbdinein.TabIndex = 3;
            this.cbdinein.Text = "Dine In";
            this.cbdinein.UseVisualStyleBackColor = true;
            this.cbdinein.CheckedChanged += new System.EventHandler(this.cbdinein_CheckedChanged);
            // 
            // cbtakeaway
            // 
            this.cbtakeaway.AutoSize = true;
            this.cbtakeaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtakeaway.ForeColor = System.Drawing.Color.White;
            this.cbtakeaway.Location = new System.Drawing.Point(327, 149);
            this.cbtakeaway.Name = "cbtakeaway";
            this.cbtakeaway.Size = new System.Drawing.Size(126, 26);
            this.cbtakeaway.TabIndex = 5;
            this.cbtakeaway.Text = "Take Away";
            this.cbtakeaway.UseVisualStyleBackColor = true;
            this.cbtakeaway.CheckedChanged += new System.EventHandler(this.cbtakeaway_CheckedChanged);
            // 
            // jumlahpelanggan
            // 
            this.jumlahpelanggan.AutoSize = true;
            this.jumlahpelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlahpelanggan.ForeColor = System.Drawing.Color.White;
            this.jumlahpelanggan.Location = new System.Drawing.Point(75, 202);
            this.jumlahpelanggan.Name = "jumlahpelanggan";
            this.jumlahpelanggan.Size = new System.Drawing.Size(158, 22);
            this.jumlahpelanggan.TabIndex = 6;
            this.jumlahpelanggan.Text = "Jumlah Pelanggan";
            // 
            // txjumlahpel
            // 
            this.txjumlahpel.Location = new System.Drawing.Point(273, 198);
            this.txjumlahpel.Name = "txjumlahpel";
            this.txjumlahpel.Size = new System.Drawing.Size(97, 26);
            this.txjumlahpel.TabIndex = 7;
            // 
            // makanan
            // 
            this.makanan.AutoSize = true;
            this.makanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makanan.ForeColor = System.Drawing.Color.White;
            this.makanan.Location = new System.Drawing.Point(75, 272);
            this.makanan.Name = "makanan";
            this.makanan.Size = new System.Drawing.Size(83, 22);
            this.makanan.TabIndex = 10;
            this.makanan.Text = "Makanan";
            // 
            // minuman
            // 
            this.minuman.AutoSize = true;
            this.minuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuman.ForeColor = System.Drawing.Color.White;
            this.minuman.Location = new System.Drawing.Point(575, 268);
            this.minuman.Name = "minuman";
            this.minuman.Size = new System.Drawing.Size(82, 22);
            this.minuman.TabIndex = 11;
            this.minuman.Text = "Minuman";
            // 
            // jumlahmakan
            // 
            this.jumlahmakan.AutoSize = true;
            this.jumlahmakan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlahmakan.ForeColor = System.Drawing.Color.White;
            this.jumlahmakan.Location = new System.Drawing.Point(75, 330);
            this.jumlahmakan.Name = "jumlahmakan";
            this.jumlahmakan.Size = new System.Drawing.Size(67, 22);
            this.jumlahmakan.TabIndex = 12;
            this.jumlahmakan.Text = "Jumlah";
            // 
            // hargamakan
            // 
            this.hargamakan.AutoSize = true;
            this.hargamakan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargamakan.ForeColor = System.Drawing.Color.White;
            this.hargamakan.Location = new System.Drawing.Point(75, 393);
            this.hargamakan.Name = "hargamakan";
            this.hargamakan.Size = new System.Drawing.Size(59, 22);
            this.hargamakan.TabIndex = 13;
            this.hargamakan.Text = "Harga";
            // 
            // hargaminum
            // 
            this.hargaminum.AutoSize = true;
            this.hargaminum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaminum.ForeColor = System.Drawing.Color.White;
            this.hargaminum.Location = new System.Drawing.Point(575, 389);
            this.hargaminum.Name = "hargaminum";
            this.hargaminum.Size = new System.Drawing.Size(59, 22);
            this.hargaminum.TabIndex = 15;
            this.hargaminum.Text = "Harga";
            // 
            // jumlahminum
            // 
            this.jumlahminum.AutoSize = true;
            this.jumlahminum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlahminum.ForeColor = System.Drawing.Color.White;
            this.jumlahminum.Location = new System.Drawing.Point(575, 330);
            this.jumlahminum.Name = "jumlahminum";
            this.jumlahminum.Size = new System.Drawing.Size(67, 22);
            this.jumlahminum.TabIndex = 14;
            this.jumlahminum.Text = "Jumlah";
            // 
            // txmakanan
            // 
            this.txmakanan.Location = new System.Drawing.Point(217, 268);
            this.txmakanan.Name = "txmakanan";
            this.txmakanan.Size = new System.Drawing.Size(277, 26);
            this.txmakanan.TabIndex = 16;
            // 
            // txminuman
            // 
            this.txminuman.Location = new System.Drawing.Point(709, 268);
            this.txminuman.Name = "txminuman";
            this.txminuman.Size = new System.Drawing.Size(277, 26);
            this.txminuman.TabIndex = 17;
            // 
            // txjumlahmakan
            // 
            this.txjumlahmakan.Location = new System.Drawing.Point(217, 326);
            this.txjumlahmakan.Name = "txjumlahmakan";
            this.txjumlahmakan.Size = new System.Drawing.Size(71, 26);
            this.txjumlahmakan.TabIndex = 18;
            // 
            // txhargamakan
            // 
            this.txhargamakan.Location = new System.Drawing.Point(217, 385);
            this.txhargamakan.Name = "txhargamakan";
            this.txhargamakan.Size = new System.Drawing.Size(164, 26);
            this.txhargamakan.TabIndex = 20;
            // 
            // txjumlahminum
            // 
            this.txjumlahminum.Location = new System.Drawing.Point(709, 326);
            this.txjumlahminum.Name = "txjumlahminum";
            this.txjumlahminum.Size = new System.Drawing.Size(71, 26);
            this.txjumlahminum.TabIndex = 22;
            // 
            // txhargaminum
            // 
            this.txhargaminum.Location = new System.Drawing.Point(709, 385);
            this.txhargaminum.Name = "txhargaminum";
            this.txhargaminum.Size = new System.Drawing.Size(164, 26);
            this.txhargaminum.TabIndex = 23;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.White;
            this.total.Location = new System.Drawing.Point(321, 475);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(68, 29);
            this.total.TabIndex = 24;
            this.total.Text = "Total";
            // 
            // txtotal
            // 
            this.txtotal.Location = new System.Drawing.Point(498, 478);
            this.txtotal.Name = "txtotal";
            this.txtotal.Size = new System.Drawing.Size(195, 26);
            this.txtotal.TabIndex = 25;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Black;
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(709, 68);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(126, 65);
            this.btnsave.TabIndex = 26;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txbayar
            // 
            this.txbayar.Location = new System.Drawing.Point(498, 538);
            this.txbayar.Name = "txbayar";
            this.txbayar.Size = new System.Drawing.Size(195, 26);
            this.txbayar.TabIndex = 28;
            // 
            // bayar
            // 
            this.bayar.AutoSize = true;
            this.bayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayar.ForeColor = System.Drawing.Color.White;
            this.bayar.Location = new System.Drawing.Point(325, 534);
            this.bayar.Name = "bayar";
            this.bayar.Size = new System.Drawing.Size(74, 29);
            this.bayar.TabIndex = 27;
            this.bayar.Text = "Bayar";
            // 
            // txkembalian
            // 
            this.txkembalian.Location = new System.Drawing.Point(498, 595);
            this.txkembalian.Name = "txkembalian";
            this.txkembalian.Size = new System.Drawing.Size(195, 26);
            this.txkembalian.TabIndex = 30;
            // 
            // kembalian
            // 
            this.kembalian.AutoSize = true;
            this.kembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kembalian.ForeColor = System.Drawing.Color.White;
            this.kembalian.Location = new System.Drawing.Point(325, 591);
            this.kembalian.Name = "kembalian";
            this.kembalian.Size = new System.Drawing.Size(128, 29);
            this.kembalian.TabIndex = 29;
            this.kembalian.Text = "Kembalian";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(998, 744);
            this.Controls.Add(this.txkembalian);
            this.Controls.Add(this.kembalian);
            this.Controls.Add(this.txbayar);
            this.Controls.Add(this.bayar);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtotal);
            this.Controls.Add(this.total);
            this.Controls.Add(this.txhargaminum);
            this.Controls.Add(this.txjumlahminum);
            this.Controls.Add(this.txhargamakan);
            this.Controls.Add(this.txjumlahmakan);
            this.Controls.Add(this.txminuman);
            this.Controls.Add(this.txmakanan);
            this.Controls.Add(this.hargaminum);
            this.Controls.Add(this.jumlahminum);
            this.Controls.Add(this.hargamakan);
            this.Controls.Add(this.jumlahmakan);
            this.Controls.Add(this.minuman);
            this.Controls.Add(this.makanan);
            this.Controls.Add(this.txjumlahpel);
            this.Controls.Add(this.jumlahpelanggan);
            this.Controls.Add(this.cbtakeaway);
            this.Controls.Add(this.cbdinein);
            this.Controls.Add(this.jenis);
            this.Controls.Add(this.judul);
            this.Name = "Form1";
            this.Text = "KOPISINI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.Label jenis;
        private System.Windows.Forms.CheckBox cbdinein;
        private System.Windows.Forms.CheckBox cbtakeaway;
        private System.Windows.Forms.Label jumlahpelanggan;
        private System.Windows.Forms.TextBox txjumlahpel;
        private System.Windows.Forms.Label makanan;
        private System.Windows.Forms.Label minuman;
        private System.Windows.Forms.Label jumlahmakan;
        private System.Windows.Forms.Label hargamakan;
        private System.Windows.Forms.Label hargaminum;
        private System.Windows.Forms.Label jumlahminum;
        private System.Windows.Forms.TextBox txmakanan;
        private System.Windows.Forms.TextBox txminuman;
        private System.Windows.Forms.TextBox txjumlahmakan;
        private System.Windows.Forms.TextBox txhargamakan;
        private System.Windows.Forms.TextBox txjumlahminum;
        private System.Windows.Forms.TextBox txhargaminum;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox txtotal;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txbayar;
        private System.Windows.Forms.Label bayar;
        private System.Windows.Forms.TextBox txkembalian;
        private System.Windows.Forms.Label kembalian;
    }
}

