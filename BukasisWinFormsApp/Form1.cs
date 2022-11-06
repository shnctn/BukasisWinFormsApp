using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace BukasisWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string oturumKodu, aktarým;
        int pkBirim = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private  void button1_Click(object sender, EventArgs e)
        {
            string kullaniciKodu =  textBox2.Text;
            string kullaniciSifre = textBox3.Text;
            string link = "api/Yetkilendirme/kullaniciGiris";


            if (kullaniciKodu != "" && kullaniciSifre != "")
            {
                string response = bukasis.post(kullaniciKodu, kullaniciSifre, link);

                JObject person = JsonConvert.DeserializeObject<JObject>(response);
                   
                if (person["veri"].ToString()!="")
                {
                    MessageBox.Show("Hoþ Geldiniz " + person["veri"]["kullaniciAdi"].ToString());
                    groupBox1.Visible = false;
                    lblot.Visible = true;
                    lblOturum.Visible = true;
                    lblOturum.Text = person["veri"]["oturum"].ToString();
                    oturumKodu = person["veri"]["oturum"].ToString();

                    btnKBG.Visible = true;
                    rtb.Visible = true;
                    rtb.Clear();
                    rtb.Text = bukasis.jsonResponse(response);
                }
                else
                {
                    MessageBox.Show(person["bilgi"]["mesaj"].ToString());
                }
            }
            else
            {
                MessageBox.Show("lüften kullanýcý adý ve þifrenizi giriniz.");
            }

        }

        private void btnKBG_Click(object sender, EventArgs e)
        {
            string link = "api/yetkili/Kullanici/kullaniciBilgileriGetir";

            string response = bukasis.get(oturumKodu, link);

            if (response!=null)
            {
                JObject person = JsonConvert.DeserializeObject<JObject>(response);
                groupBox1.Visible = false;
                lblot.Visible = true;
                lblOturum.Visible = true;
                lblOturum.Text = oturumKodu;
                btnKBG.Visible = false;
                btnYGGBG.Visible = true;
                pkBirim =Convert.ToInt32(person["veri"]["birimTemel"]["pkBirim"].ToString());
                
            }
            rtb.Clear();
            rtb.Text=bukasis.jsonResponse(response);

        }

        private void btnYGGBG_Click(object sender, EventArgs e)
        {
            string link = "api/yetkili/HastaTakip/yatakGenelGorunumBilgileriGetir/";

            string response = bukasis.get(oturumKodu, link+pkBirim);
            if (response!=null)
            {
                btnYGGBG.Visible = false;
                btnHasta.Visible = true;

            }
            rtb.Clear();
            rtb.Text = bukasis.jsonResponse(response);
            aktarým = response;
            
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            HastaNotEkle hastaNotEkle = new HastaNotEkle(aktarým,oturumKodu);
            hastaNotEkle.ShowDialog();
            

        }
    }
}