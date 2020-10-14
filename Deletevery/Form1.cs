using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deletevery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean dosyami;
        string klasorismi;
        string dosyaismi;
        


        private void selectFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dosyasec = new OpenFileDialog();
            dosyasec.ShowDialog();
            dosyaismi = dosyasec.FileName;
            dosyami = true;
            lblintro.Text = "Selected File: " + dosyaismi;
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
             

        private void btnstart_Click(object sender, EventArgs e)
        {
            if(!dosyami)
            {
                try
                {
                    klasil kurbanpazari = new klasil();
                    string[] kurbanlik = kurbanpazari.Klasor(klasorismi);
                    sifreleme operation = new sifreleme();
                    
                    for (int i = 0; i < kurbanlik.Length; i++)
                    {
                        lblintro.Text = "Target: " + kurbanlik[i];
                        lblintro.Text = "Generating Key...";
                        byte[] alektar = operation.alektar();
                        lblintro.Text = "Crypto Operation...";
                        operation.sifreleagam(kurbanlik[i],  alektar);
                        lblintro.Text = "Deleting target...";
                        kurbanpazari.silagam(kurbanlik[i]);
                    }
                    lblintro.Text = "COMPLETED";
                }
                catch
                {
                    lblintro.Text = "error...";
                }
            }
            else
            {
                klasil silme = new klasil();
                sifreleme operation2 = new sifreleme();
                lblintro.Text = "Generating Key...";
                byte[] alektar = operation2.alektar();
                lblintro.Text = "Crypto Operation...";
                operation2.sifreleagam(dosyaismi, alektar);
                lblintro.Text = "Deleting target...";
                silme.silagam(dosyaismi);
                lblintro.Text = "COMPLETED";
            }

        }

        private void slctfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog klasorsec = new FolderBrowserDialog();
            klasorsec.ShowDialog();
            klasorismi = klasorsec.SelectedPath;
            dosyami = false;
            lblintro.Text = "Selected Folder: " + klasorismi;

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblintro_Click(object sender, EventArgs e)
        {

        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Removed files will never back like her...");
        }

        private void wutaboutmen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program encryption file and delete it.  " + "\n" + "twitter.com/MHMMD_KLC");
            
        }
    }
}
