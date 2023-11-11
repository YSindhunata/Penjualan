namespace ProjectPenjualan
{
    partial class FrmPenjualan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.rdoKredit = new System.Windows.Forms.RadioButton();
            this.rdoTunai = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPelanggan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTanggal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwPenjualan = new System.Windows.Forms.ListView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSimpan);
            this.groupBox1.Controls.Add(this.rdoKredit);
            this.groupBox1.Controls.Add(this.rdoTunai);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtPelanggan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTanggal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNota);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(656, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " [ Entri Penjualan ] ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(548, 134);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(439, 134);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 28);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // rdoKredit
            // 
            this.rdoKredit.AutoSize = true;
            this.rdoKredit.Location = new System.Drawing.Point(439, 31);
            this.rdoKredit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoKredit.Name = "rdoKredit";
            this.rdoKredit.Size = new System.Drawing.Size(62, 20);
            this.rdoKredit.TabIndex = 2;
            this.rdoKredit.Text = "Kredit";
            this.rdoKredit.UseVisualStyleBackColor = true;
            this.rdoKredit.CheckedChanged += new System.EventHandler(this.rdoKredit_CheckedChanged);
            // 
            // rdoTunai
            // 
            this.rdoTunai.AutoSize = true;
            this.rdoTunai.Checked = true;
            this.rdoTunai.Location = new System.Drawing.Point(355, 30);
            this.rdoTunai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoTunai.Name = "rdoTunai";
            this.rdoTunai.Size = new System.Drawing.Size(62, 20);
            this.rdoTunai.TabIndex = 1;
            this.rdoTunai.TabStop = true;
            this.rdoTunai.Text = "Tunai";
            this.rdoTunai.UseVisualStyleBackColor = true;
            this.rdoTunai.CheckedChanged += new System.EventHandler(this.rdoTunai_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(104, 94);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPelanggan
            // 
            this.txtPelanggan.Location = new System.Drawing.Point(355, 62);
            this.txtPelanggan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPelanggan.Name = "txtPelanggan";
            this.txtPelanggan.Size = new System.Drawing.Size(292, 22);
            this.txtPelanggan.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Jenis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pelanggan";
            // 
            // txtTanggal
            // 
            this.txtTanggal.Location = new System.Drawing.Point(104, 62);
            this.txtTanggal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(132, 22);
            this.txtTanggal.TabIndex = 3;
            this.txtTanggal.TextChanged += new System.EventHandler(this.txtTanggal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tanggal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(104, 30);
            this.txtNota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(132, 22);
            this.txtNota.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lvwPenjualan);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Location = new System.Drawing.Point(16, 210);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(656, 297);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " [ Daftar Nota ] ";
            // 
            // lvwPenjualan
            // 
            this.lvwPenjualan.HideSelection = false;
            this.lvwPenjualan.Location = new System.Drawing.Point(8, 23);
            this.lvwPenjualan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwPenjualan.Name = "lvwPenjualan";
            this.lvwPenjualan.Size = new System.Drawing.Size(639, 226);
            this.lvwPenjualan.TabIndex = 2;
            this.lvwPenjualan.UseCompatibleStateImageBehavior = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(481, 263);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(167, 16);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total: 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hapus Nota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Penjualan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTanggal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtPelanggan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoKredit;
        private System.Windows.Forms.RadioButton rdoTunai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwPenjualan;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button1;
    }
}

