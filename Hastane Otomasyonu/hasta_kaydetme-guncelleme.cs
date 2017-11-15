using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class hasta_kaydetme_guncelleme : Form
    {
        public hasta_kaydetme_guncelleme()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=hastane.mdb;Jet OLEDB:Database Password=1994;");
       
        void kayit()
        {
            if (TextBox1.Text == "")
            { errorProvider1.SetError(TextBox1, "T.C. GİRİLMESİ ZORUNLU!"); }
            else
            {
                baglan.Open();
                OleDbCommand sorgu = new OleDbCommand("select * from kayit where TC = '" + TextBox1.Text + "'", baglan);
                OleDbDataReader oku = sorgu.ExecuteReader();
                if (oku.Read())
                { MessageBox.Show("KAYITLI HASTA!"); }
                else
                {
                    OleDbCommand kayit = new OleDbCommand("insert into kayit (TC,ADI,SOYADI,DoğumTarihi,CEP,CİNSİYETİ,SİGORTA,KanGrubu,BabaAdı,AnneAdı,foto) values (@TC, @ADI, @SOYADI, @DoğumTarihi, @CEP, @CİNSİYETİ, @SİGORTA, @KanGrubu, @BabaAdı, @AnneAdı, @foto)", baglan);
                    kayit.Parameters.AddWithValue("@TC", TextBox1.Text);
                    kayit.Parameters.AddWithValue("@ADI", TextBox2.Text);
                    kayit.Parameters.AddWithValue("@SOYADI", TextBox3.Text);
                    kayit.Parameters.AddWithValue("@DoğumTarihi", DateTimePicker1.Text);
                    kayit.Parameters.AddWithValue("@CEP", MaskedTextBox1.Text);
                    kayit.Parameters.AddWithValue("@CİNSİYETİ", ComboBox1.Text);
                    kayit.Parameters.AddWithValue("@SİGORTA", ComboBox2.Text);
                    kayit.Parameters.AddWithValue("@KanGrubu", ComboBox3.Text);
                    kayit.Parameters.AddWithValue("@BabaAdı", TextBox4.Text);
                    kayit.Parameters.AddWithValue("@AnneAdı", TextBox5.Text);
                    MemoryStream ms = new MemoryStream();
                    PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    kayit.Parameters.AddWithValue("@foto", ms.ToArray());
                    kayit.ExecuteNonQuery();
                    ms.Close();
                    MessageBox.Show("KAYIT BAŞARILI.");
                }
                baglan.Close();          
            }
        }

        void guncelleme()
        {
            if (TextBox1.Text == "")
            { errorProvider1.SetError(TextBox1, "T.C. GİRİLMESİ ZORUNLU!"); }
            else
            {
                baglan.Open();
                OleDbCommand guncelleme = new OleDbCommand("update kayit set TC=@TC, ADI=@ADI, SOYADI=@SOYADI, DoğumTarihi=@DoğumTarihi, CEP=@CEP, CİNSİYETİ=@CİNSİYETİ, SİGORTA=@SİGORTA, KanGrubu=@KanGrubu, BabaAdı=@BabaAdı, AnneAdı=@AnneAdı, foto=@foto where ID=@ID", baglan);
                guncelleme.Parameters.AddWithValue("@TC", TextBox1.Text);
                guncelleme.Parameters.AddWithValue("@ADI", TextBox2.Text);
                guncelleme.Parameters.AddWithValue("@SOYADI", TextBox3.Text);
                guncelleme.Parameters.AddWithValue("@DoğumTarihi", DateTimePicker1.Text);
                guncelleme.Parameters.AddWithValue("@CEP", MaskedTextBox1.Text);
                guncelleme.Parameters.AddWithValue("@CİNSİYETİ", ComboBox1.Text);
                guncelleme.Parameters.AddWithValue("@SİGORTA", ComboBox2.Text);
                guncelleme.Parameters.AddWithValue("@KanGrubu", ComboBox3.Text);
                guncelleme.Parameters.AddWithValue("@BabaAdı", TextBox4.Text);
                guncelleme.Parameters.AddWithValue("@AnneAdı", TextBox5.Text);
                MemoryStream ms = new MemoryStream();
                PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                guncelleme.Parameters.AddWithValue("@foto", ms.ToArray());
                guncelleme.Parameters.AddWithValue("@ID", tb_id.Text);
                guncelleme.ExecuteNonQuery();
                ms.Close();
                baglan.Close();
                MessageBox.Show("GÜNCELLEME BAŞARILI.");     
            }
        }

        private void bt_kaydet_Click(object sender, EventArgs e)
        { kayit(); }

        private void bt_guncelle_Click(object sender, EventArgs e)
        { guncelleme(); }
        private void bt_resimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog resim = new OpenFileDialog();
            resim.Filter = "Resim Dosyaları |*.jpg;*.bmp;*.png";
            resim.Title = "Resim Seçiniz...";
            if (resim.ShowDialog() == DialogResult.OK)
            { PictureBox1.Image = Image.FromFile(resim.FileName); } 
        }

        private void bt_resinsil_Click(object sender, EventArgs e)
        { PictureBox1.Image = PictureBox2.Image; }

        private void hasta_kaydetme_guncelleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            hasta_guncelleme_silme_DG hgsDG = new hasta_guncelleme_silme_DG();
            if(bt_guncelle.Enabled == true) 
            {
                hgsDG.DGkisilistele();
                hgsDG.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { tb_yetkilikodu.Visible = true; }
            else {
                TextBox1.Enabled = false;
                tb_yetkilikodu.Visible = false;
            }
        }

        private void tb_yetkilikodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (tb_yetkilikodu.Text == "") { errorProvider1.SetError(tb_yetkilikodu, "YETKİLİ KODU'NU GİRİNİZ!"); }
                else
                {
                    errorProvider1.Clear();
                    baglan.Open();
                    OleDbCommand yetkilikodsorgu = new OleDbCommand("select * from yetkili where KOD = '" + tb_yetkilikodu.Text + "'", baglan);
                    OleDbDataReader kodoku = yetkilikodsorgu.ExecuteReader();
                    if (kodoku.Read())
                    {
                        tb_yetkilikodu.Visible = false;
                        TextBox1.Enabled = true;
                        tb_yetkilikodu.Clear();
                    }
                    else { errorProvider1.SetError(tb_yetkilikodu, "YANLIŞ KOD!"); }
                    baglan.Close();
                }            
            }
        }

        private void tb_yetkilikodu_TextChanged(object sender, EventArgs e)
        {
            if (tb_yetkilikodu.Text == "") { errorProvider1.SetError(tb_yetkilikodu, "YETKİLİ KODU'NU GİRİNİZ!"); }
            else if (tb_yetkilikodu.Text != "") { errorProvider1.Clear(); }
        }
    }
}
