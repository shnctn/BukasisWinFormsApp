using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukasisWinFormsApp
{
    public partial class HastaNotEkle : Form
    {
        public string _aktarim, _oturumkodu;
        string value;
        public HastaNotEkle(string aktarım,string oturumKodu)
        {
            InitializeComponent();
            this._aktarim = aktarım;
            this._oturumkodu=oturumKodu; 
        }

        private void HastaNotEkle_Load(object sender, EventArgs e)
        {
            JObject yatakBg = JsonConvert.DeserializeObject<JObject>(_aktarim);

            foreach (var item in yatakBg["veri"])
            {
                comboBox1.Items.Add(item["yatak"]["yatakTanimi"]);
                comboBox1.DisplayMember = item["pkBasvuru"].ToString();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string display = comboBox1.SelectedItem.ToString();
                value = comboBox1.DisplayMember.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (value != null)
            {
                if (textBox1.Text!="" && richTextBox1.Text!="" && richTextBox2.Text!="")
                {
                    JObject nots = new JObject()
                    {
                        ["pkKlinikNot"] = 0,
                        ["notBasligi"] = textBox1.Text,
                        ["notDetayi"] = richTextBox1.Text,
                        ["notDetayiText"] = richTextBox2.Text,
                        ["notEklenmeZamani"] = DateTime.Now,
                        ["notGuncellenmeZamani"] = DateTime.Now,
                        ["fkKullanici"] = 0,
                        ["ekleyenKullaniciAdiSoyadi"] = "string",
                        ["konsultasyon"] = true,
                        ["hemsireMi"] = true

                    };

                    var response = bukasis.postObject(nots, value, _oturumkodu);
                    JObject mesaj = JsonConvert.DeserializeObject<JObject>(response);
                    MessageBox.Show(mesaj["bilgi"]["mesaj"].ToString());
                }
                else
                {
                    MessageBox.Show("Lüften ilgili alanları doldurunuz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen PkBaşvuru değerini seçiniz");
            }
        }
    }
}
