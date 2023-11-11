using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectPenjualan
{
    public partial class FrmPenjualan : Form
    {
        // membuat objek collection dengan nama daftarNota
        private List<Penjualan> daftarNota = new List<Penjualan>();
        private String jenis;
        public FrmPenjualan()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwPenjualan.View = View.Details;
            lvwPenjualan.FullRowSelect = true;
            lvwPenjualan.GridLines = true;
            lvwPenjualan.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwPenjualan.Columns.Add("Nota", 91, HorizontalAlignment.Center);
            lvwPenjualan.Columns.Add("Jenis", 70, HorizontalAlignment.Left);
            lvwPenjualan.Columns.Add("Tanggal", 70, HorizontalAlignment.Center);
            lvwPenjualan.Columns.Add("Pelanggan", 100, HorizontalAlignment.Center);
            lvwPenjualan.Columns.Add("Total", 100, HorizontalAlignment.Center);
        }

        private void ResetForm()
        {
            txtNota.Clear();
            txtPelanggan.Clear();
            txtTanggal.Clear();
            txtTotal.Text = "0";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Penjualan pj = new Penjualan();
            pj.Nota = txtNota.Text;
            pj.jenis = jenis;
            pj.Pelanggan = txtPelanggan.Text;
            pj.Tanggal = txtTanggal.Text;
            pj.Total = int.Parse(txtTotal.Text);

            daftarNota.Add(pj);

            var msg = "Data penjualan berhasil disimpan.";

            // tampilkan dialog informasi
            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            // tampilkan penjualan ke listview
            TampilkanData();

            // kosongkan form input
            ResetForm();
        }

        private void TampilkanData()
        {

            // kosongkan data listview
            lvwPenjualan.Items.Clear();

            foreach (var pj in daftarNota)
            {
                var noUrut = lvwPenjualan.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pj.Nota);
                item.SubItems.Add(pj.jenis);
                item.SubItems.Add(pj.Tanggal);
                item.SubItems.Add(pj.Pelanggan);
                item.SubItems.Add(pj.Total.ToString());

                lvwPenjualan.Items.Add(item);
            }
        }

        private void rdoTunai_CheckedChanged(object sender, EventArgs e)
        {
            jenis = "Tunai";
        }

        private void rdoKredit_CheckedChanged(object sender, EventArgs e)
        {
            jenis = "Kredit";
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            int totalNota = 0;
            foreach (Penjualan p in daftarNota)
            {
                totalNota += p.Total;
            }


            lblTotal.Text = "total : " + totalNota.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           

        }

        private void txtTanggal_TextChanged(object sender, EventArgs e)
        {
            bool valid = true;
            foreach (char c in txtTanggal.Text)
            {
                if (!char.IsDigit(c) && c != '/' && c != '-')
                {
                    valid = false;
                    break;
                }
            }


            if (!valid)
            {
                txtTanggal.Text = txtTanggal.Text.Substring(0, txtTanggal.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lvwPenjualan.SelectedItems.Count > 0)
            {
                // tampilkan konfirmasi
                var konfirmasi = MessageBox.Show("Apakah data nota ingin  dihapus ? ", "Konfirmasi",

                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil index list yang di pilih
                    var index = lvwPenjualan.SelectedIndices[0];
                    // hapus objek mahasiswa dari list
                    daftarNota.RemoveAt(index);
                    // refresh tampilan listivew
                    TampilkanData();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data nota belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
