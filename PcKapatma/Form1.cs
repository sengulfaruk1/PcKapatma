using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcKapatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult soru;
            soru = MessageBox.Show("Biglisayar Kapatılsın mı?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(soru==DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown","-s");
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult soru=MessageBox.Show("Biglisayar Yeniden başlatılsın mı?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
            
                if(soru==DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("shutdown","-r");
                
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult soru=MessageBox.Show("Biglisayar Uyku moduna geçtsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
            
                if(soru==DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("shutdown","-h");
                
                }
        }
,    }
}
