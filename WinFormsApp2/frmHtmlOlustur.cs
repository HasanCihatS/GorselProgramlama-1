namespace WinFormsApp2
{
    public partial class frmHtmlOlustur : Form
    {
        

        public frmHtmlOlustur()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            string sayfaIsmi = txtSayfaIsmi.Text;
            string sayfaBasligi = txtSayfaBasligi.Text;
            string yaziBasligi = txtYaziBasligi.Text;
            string yonlendirmeLinki = txtYonlendirmeLinki.Text;
            string yonlendirmeLinkiYazi = txtYonlendirmeLinkiYazi.Text;
            string icerik = txtIcerik.Text;


            StreamWriter streamWriter = new StreamWriter($"./{sayfaIsmi}.html");

            string htmlYazi = $@"
                <html>
                    <head>
                        <title>{sayfaBasligi}</title>
                    </head>
                    <body>
                        <h1>{yaziBasligi}</h1>
                        <p>{icerik}</p>
                        <a href='{yonlendirmeLinki}'>{yonlendirmeLinkiYazi}</a>
                    </body>
                </html>
            ";

            streamWriter.Write(htmlYazi);
            streamWriter.Close();
        }
    }
}