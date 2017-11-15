using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        
        private void YeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hasta_kaydetme_guncelleme hkg = new hasta_kaydetme_guncelleme();
            hkg.Show();
        }

        private void KayıtGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hasta_guncelleme_silme_DG hgsDG = new hasta_guncelleme_silme_DG();
            hgsDG.Show();
        }
    }
}
