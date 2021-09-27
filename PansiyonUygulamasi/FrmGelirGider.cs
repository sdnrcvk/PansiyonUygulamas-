using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonUygulamasi
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S1PQKS2;Initial Catalog=PapatyamPansiyon;Integrated Security=True");
        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();
            //alınan ürünlerin giderleri
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select sum(Gida+Icecek+Cerezler) as toplam from Stoklar", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                LblAlinanUrunler.Text = oku1["toplam"].ToString();
            }
            baglanti.Close();
            //fatura giderleri
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Elektrik+Su+Internet) as toplam from Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblFaturalar.Text = oku2["toplam"].ToString();
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //personel giderleri
            int personel;
            int maas = 1500;
            personel = Convert.ToInt16(textBox1.Text);
            LblPersonelMaas.Text = (personel * maas).ToString();

            //toplam gelir-gider
            int kasa, personelMaas, alinanUrun, faturalar;
            kasa = Convert.ToInt16(LblKasaToplam.Text);
            personelMaas = Convert.ToInt16(LblPersonelMaas.Text);
            alinanUrun = Convert.ToInt16(LblAlinanUrunler.Text);
            faturalar = Convert.ToInt16(LblFaturalar.Text);
            LblSonuc.Text = (kasa - (personelMaas + alinanUrun + faturalar)).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LblFaturalar_Click(object sender, EventArgs e)
        {

        }

        private void LblAlinanUrunler_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
