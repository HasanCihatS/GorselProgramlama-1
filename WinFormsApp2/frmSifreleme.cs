using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmSifreleme : Form
    {
        public frmSifreleme()
        {
            InitializeComponent();
        }
          
        private void btnDosyaAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                StreamReader reader = new StreamReader(filePath);
                byte[] data = Convert.FromBase64String(reader.ReadToEnd());
                txtCozulmusIcerik.Text = Encoding.UTF8.GetString(data);
                reader.Close();
                
            }
        }

        private void btnDosyaKaydet_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("./sifrelenmisMetin.txt");
            string sifrelenmisMetin = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtCozulmusIcerik.Text)); ;
            streamWriter.Write(sifrelenmisMetin);
            streamWriter.Close();
        }
    }
}
