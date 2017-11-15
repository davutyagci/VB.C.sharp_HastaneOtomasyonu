using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class yetkiligirişi : Form
    {
        public yetkiligirişi()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=hastane.mdb;Jet OLEDB:Database Password=1994;");
        
        private void Button1_Click(object sender, EventArgs e)
        {
            hasta_guncelleme_silme_DG kontrol = new hasta_guncelleme_silme_DG();
            if (TextBox1.Text == "")
            { errorProvider1.SetError(TextBox1, "YETKİLİ KODU'NU GİRİNİZ!"); }
            else
            {
                errorProvider1.Clear();
                baglan.Open();
                OleDbCommand sorgu = new OleDbCommand("Select *From yetkili where KOD = '"+TextBox1.Text+"'", baglan);
                OleDbDataReader oku = sorgu.ExecuteReader();
                if (oku.Read())
                {
                        
                }
                else
                { errorProvider1.SetError(TextBox1, "YANLIŞ KOD!"); }
                baglan.Close();

            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text == "") { errorProvider1.SetError(TextBox1, "YETKİLİ KODU'NU GİRİNİZ!"); }
            else if (TextBox1.Text != "") { errorProvider1.Clear(); }
        }
    }
}
