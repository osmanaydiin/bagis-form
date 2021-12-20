using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //DSN için oluşturulan isim kullanılarak odbc bağlantısı oluşturulur.
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=veritabanim1; user ID=postgres; password=asd123321");

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("once islemi seciniz ardindan boş yerleri doldurunuz..");    
        }

        void sayfayiTemizle()
        {
            txtAdi.Clear(); txtSoyadi.Clear(); txtKisiNo.Clear(); txtSehir.Clear(); txtBolge.Clear(); 
            txtUlke.Clear(); txtAdresNo.Clear(); txtTelefon.Clear(); txtIletisimNo.Clear(); txtBagisMiktar.Clear();
            txtBagisNo.Clear(); txtBagisUlke.Clear(); txtBagisAdresNo.Clear();
        }
        void bagisTurEkle()
        {
            baglanti.Open();
            if (cmbBagisTur.SelectedIndex == 0)
            {
                NpgsqlCommand bagisEkleA2 = new NpgsqlCommand("insert into sukuyusu (bagisno, kisino, iletisimno) values (@p1, @p2, @p3)", baglanti);
                bagisEkleA2.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                bagisEkleA2.Parameters.AddWithValue("@p2", int.Parse(txtKisiNo.Text));
                bagisEkleA2.Parameters.AddWithValue("@p3", int.Parse(txtIletisimNo.Text));
                bagisEkleA2.ExecuteNonQuery();
            }
            else if (cmbBagisTur.SelectedIndex == 1)
            {
                NpgsqlCommand bagisEkleA2 = new NpgsqlCommand("insert into kurban (bagisno, kisino, iletisimno) values (@p1, @p2, @p3)", baglanti);
                bagisEkleA2.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                bagisEkleA2.Parameters.AddWithValue("@p2", int.Parse(txtKisiNo.Text));
                bagisEkleA2.Parameters.AddWithValue("@p3", int.Parse(txtIletisimNo.Text));
                bagisEkleA2.ExecuteNonQuery();
            }
            else if (cmbBagisTur.SelectedIndex == 2)
            {
                NpgsqlCommand bagisEkleA2 = new NpgsqlCommand("insert into yetimhamiligi (bagisno, kisino, iletisimno) values (@p1, @p2, @p3)", baglanti);
                bagisEkleA2.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                bagisEkleA2.Parameters.AddWithValue("@p2", int.Parse(txtKisiNo.Text));
                bagisEkleA2.Parameters.AddWithValue("@p3", int.Parse(txtIletisimNo.Text));
                bagisEkleA2.ExecuteNonQuery();
            }
            else
            {
                NpgsqlCommand bagisEkleA2 = new NpgsqlCommand("insert into sadaka (bagisno, kisino, iletisimno) values (@p1, @p2, @p3)", baglanti);
                bagisEkleA2.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                bagisEkleA2.Parameters.AddWithValue("@p2", int.Parse(txtKisiNo.Text));
                bagisEkleA2.Parameters.AddWithValue("@p3", int.Parse(txtIletisimNo.Text));
                bagisEkleA2.ExecuteNonQuery();
            }
            baglanti.Close();
            MessageBox.Show("bagis turu eklendi");
        }
        private void rdbBagisciEkle_CheckedChanged(object sender, EventArgs e)
        {
            sayfayiTemizle();
            txtAdi.ReadOnly = false; txtSoyadi.ReadOnly = false; txtIletisimNo.ReadOnly = false;
            txtAdresNo.ReadOnly = false; txtBolge.ReadOnly = false; txtSehir.ReadOnly = false; txtUlke.ReadOnly = false;
            txtBagisNo.ReadOnly = false; txtBagisMiktar.ReadOnly = false; txtTelefon.ReadOnly = false;
            txtBagisUlke.ReadOnly = false; txtBagisAdresNo.ReadOnly = false; txtKisiNo.ReadOnly = false;
        }

        private void rdbBagisEkle_CheckedChanged(object sender, EventArgs e)
        {
            sayfayiTemizle();
            txtAdi.ReadOnly = true; txtSoyadi.ReadOnly = true; txtIletisimNo.ReadOnly = false;
            txtAdresNo.ReadOnly = true; txtBolge.ReadOnly = true; txtSehir.ReadOnly = true; txtUlke.ReadOnly = true;
            txtBagisNo.ReadOnly = false; txtBagisMiktar.ReadOnly = false; txtTelefon.ReadOnly = true;
            txtBagisUlke.ReadOnly = false; txtBagisAdresNo.ReadOnly = false; txtKisiNo.ReadOnly = false;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (rdbBagisciEkle.Checked == true)
            {
                baglanti.Open();
                NpgsqlCommand bagisciEkleA1 = new NpgsqlCommand("insert into adres (adresno, adresturu, bolge, sehir, ulke) values (@p1, @p2, @p3, @p4, @p5 )", baglanti);
                bagisciEkleA1.Parameters.AddWithValue("@p1", int.Parse(txtAdresNo.Text));
                bagisciEkleA1.Parameters.AddWithValue("@p2", "bagisci adresi");
                bagisciEkleA1.Parameters.AddWithValue("@p3", txtBolge.Text);
                bagisciEkleA1.Parameters.AddWithValue("@p4", txtSehir.Text);
                bagisciEkleA1.Parameters.AddWithValue("@p5", txtUlke.Text);
                bagisciEkleA1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("adres eklendi");

                baglanti.Open();
                NpgsqlCommand bagisciEkleA2 = new NpgsqlCommand("insert into kisi (adresno, kisino, kisiad, kisisoyad, iletisimno, kisitur) values (@p1, @p2, @p3, @p4, @p5, @p6 )", baglanti);
                bagisciEkleA2.Parameters.AddWithValue("@p1", int.Parse(txtAdresNo.Text));
                bagisciEkleA2.Parameters.AddWithValue("@p2", int.Parse(txtKisiNo.Text));
                bagisciEkleA2.Parameters.AddWithValue("@p3", txtAdi.Text);
                bagisciEkleA2.Parameters.AddWithValue("@p4", txtSoyadi.Text);
                bagisciEkleA2.Parameters.AddWithValue("@p5", int.Parse(txtIletisimNo.Text));
                bagisciEkleA2.Parameters.AddWithValue("@p6", "bagisci");
                bagisciEkleA2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("kisi eklendi");
                
                baglanti.Open();
                NpgsqlCommand bagisciEkleA3 = new NpgsqlCommand("insert into bagisciadres (adresno, kisino) values (@p1, @p2)", baglanti);
                bagisciEkleA3.Parameters.AddWithValue("@p1", int.Parse(txtAdresNo.Text));
                bagisciEkleA3.Parameters.AddWithValue("@p2", int.Parse(txtKisiNo.Text));
                bagisciEkleA3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("bagisciadres eklendi");

                baglanti.Open();
                NpgsqlCommand bagisciEkleA4 = new NpgsqlCommand("insert into bagisci (bagistur, kisino) values (@p1, @p2)", baglanti);
                bagisciEkleA4.Parameters.AddWithValue("@p1", cmbBagisTur.SelectedItem);
                bagisciEkleA4.Parameters.AddWithValue("@p2", int.Parse(txtKisiNo.Text));
                bagisciEkleA4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("bagisci eklendi");

                baglanti.Open();
                NpgsqlCommand bagisciEkleA6 = new NpgsqlCommand("insert into adres (adresno, adresturu, bolge, sehir, ulke) values (@p1, @p2, @p3, @p4, @p5 )", baglanti);
                bagisciEkleA6.Parameters.AddWithValue("@p1", int.Parse(txtBagisAdresNo.Text));
                bagisciEkleA6.Parameters.AddWithValue("@p2", "bagis adresi");
                bagisciEkleA6.Parameters.AddWithValue("@p3", " ");
                bagisciEkleA6.Parameters.AddWithValue("@p4", " ");
                bagisciEkleA6.Parameters.AddWithValue("@p5", txtBagisUlke.Text);
                bagisciEkleA6.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("adres eklendi");

                baglanti.Open();
                NpgsqlCommand bagisAdresEkleA1 = new NpgsqlCommand("insert into bagisadres (adresno, bagisno, bagistur) values (@p1, @p2, @p3)", baglanti);
                bagisAdresEkleA1.Parameters.AddWithValue("@p1", int.Parse(txtBagisAdresNo.Text));
                bagisAdresEkleA1.Parameters.AddWithValue("@p2", int.Parse(txtBagisNo.Text));
                bagisAdresEkleA1.Parameters.AddWithValue("@p3", cmbBagisTur.SelectedItem);
                bagisAdresEkleA1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("adres bagis eklendi");

                baglanti.Open();
                NpgsqlCommand bagisEkleA1 = new NpgsqlCommand("insert into bagis (bagistur, kisino, adresno, bagisno, miktar) values (@p1, @p2, @p3, @p4, @p5)", baglanti);
                bagisEkleA1.Parameters.AddWithValue("@p1", cmbBagisTur.SelectedItem);
                bagisEkleA1.Parameters.AddWithValue("@p2", int.Parse(txtKisiNo.Text));
                bagisEkleA1.Parameters.AddWithValue("@p3", int.Parse(txtBagisAdresNo.Text));
                bagisEkleA1.Parameters.AddWithValue("@p4", int.Parse(txtBagisNo.Text));
                bagisEkleA1.Parameters.AddWithValue("@p5", int.Parse(txtBagisMiktar.Text));
                bagisEkleA1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("bagis eklendi");
                bagisTurEkle();
            }

            if (rdbBagisEkle.Checked == true)
            {
                //bağış adres ekle 
                baglanti.Open();
                NpgsqlCommand bagisAdresEkleA1 = new NpgsqlCommand("insert into adres (adresno, adresturu, bolge, sehir, ulke) values (@p1, @p2, @p3, @p4, @p5)", baglanti);
                bagisAdresEkleA1.Parameters.AddWithValue("@p1", int.Parse(txtBagisAdresNo.Text));
                bagisAdresEkleA1.Parameters.AddWithValue("@p2", "bagis adres");
                bagisAdresEkleA1.Parameters.AddWithValue("@p3", " ");
                bagisAdresEkleA1.Parameters.AddWithValue("@p4", " ");
                bagisAdresEkleA1.Parameters.AddWithValue("@p5", txtBagisUlke.Text);
                bagisAdresEkleA1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("adres eklendi eklendi");

                baglanti.Open();
                NpgsqlCommand bagisEkleA1 = new NpgsqlCommand("insert into bagis (bagistur, kisino, adresno, bagisno, miktar) values (@p1, @p2, @p3, @p4, @p5)", baglanti);
                bagisEkleA1.Parameters.AddWithValue("@p1", cmbBagisTur.SelectedItem);
                bagisEkleA1.Parameters.AddWithValue("@p2", int.Parse(txtKisiNo.Text));
                bagisEkleA1.Parameters.AddWithValue("@p3", int.Parse(txtBagisAdresNo.Text));
                bagisEkleA1.Parameters.AddWithValue("@p4", int.Parse(txtBagisNo.Text));
                bagisEkleA1.Parameters.AddWithValue("@p5", int.Parse(txtBagisMiktar.Text));
                bagisEkleA1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("bagis eklendi");
                bagisTurEkle();
                
                baglanti.Open();
                if (cmbBagisTur.SelectedIndex == 0)
                {
                    NpgsqlCommand bagisAdresEkleA2 = new NpgsqlCommand("insert into bagisadres (adresno, bagisno, bagistur) values (@p1, @p2, @p3)", baglanti);
                    bagisAdresEkleA2.Parameters.AddWithValue("@p1", int.Parse(txtBagisAdresNo.Text));
                    bagisAdresEkleA2.Parameters.AddWithValue("@p2", int.Parse(txtBagisNo.Text));
                    bagisAdresEkleA2.Parameters.AddWithValue("@p3", "SU KUYUSU");
                    bagisAdresEkleA2.ExecuteNonQuery();
                }
                else if (cmbBagisTur.SelectedIndex == 1)
                {
                    NpgsqlCommand bagisAdresEkleA2 = new NpgsqlCommand("insert into bagisadres (adresno, bagisno, bagistur) values (@p1, @p2, @p3)", baglanti);
                    bagisAdresEkleA2.Parameters.AddWithValue("@p1", int.Parse(txtBagisAdresNo.Text));
                    bagisAdresEkleA2.Parameters.AddWithValue("@p2", int.Parse(txtBagisNo.Text));
                    bagisAdresEkleA2.Parameters.AddWithValue("@p3", "KURBAN");
                    bagisAdresEkleA2.ExecuteNonQuery();
                }
                else if (cmbBagisTur.SelectedIndex == 2)
                {
                    NpgsqlCommand bagisAdresEkleA2 = new NpgsqlCommand("insert into bagisadres (adresno, bagisno, bagistur) values (@p1, @p2, @p3)", baglanti);
                    bagisAdresEkleA2.Parameters.AddWithValue("@p1", int.Parse(txtBagisAdresNo.Text));
                    bagisAdresEkleA2.Parameters.AddWithValue("@p2", int.Parse(txtBagisNo.Text));
                    bagisAdresEkleA2.Parameters.AddWithValue("@p3", "YETIM HAMILIGI");
                    bagisAdresEkleA2.ExecuteNonQuery();
                }
                else
                {
                    NpgsqlCommand bagisAdresEkleA2 = new NpgsqlCommand("insert into bagisadres (adresno, bagisno, bagistur) values (@p1, @p2, @p3)", baglanti);
                    bagisAdresEkleA2.Parameters.AddWithValue("@p1", int.Parse(txtBagisAdresNo.Text));
                    bagisAdresEkleA2.Parameters.AddWithValue("@p2", int.Parse(txtBagisNo.Text));
                    bagisAdresEkleA2.Parameters.AddWithValue("@p3", "SADAKA");
                    bagisAdresEkleA2.ExecuteNonQuery();
                }
                baglanti.Close();
                MessageBox.Show("adres eklendi eklendi");
            }

            if (rdbBagisciSil.Checked == true)
            {

                baglanti.Open();
                string adresNo = " ";
                NpgsqlCommand bagisciSilA4 = new NpgsqlCommand("select adresno from kisi where kisino=@p1", baglanti);
                bagisciSilA4.Parameters.AddWithValue("@p1", int.Parse(txtKisiNo.Text));
                NpgsqlDataReader reader = bagisciSilA4.ExecuteReader();
                while (reader.Read())
                {
                    adresNo = reader[0].ToString();
                }
                baglanti.Close();
                MessageBox.Show("bagisci adres alindi;");

                baglanti.Open();
                NpgsqlCommand bagisciSilA3 = new NpgsqlCommand("delete from adres where adresno=@p1", baglanti);
                bagisciSilA3.Parameters.AddWithValue("@p1", int.Parse(adresNo));
                bagisciSilA3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("adres silindi;");
                /*
                baglanti.Open();
                NpgsqlCommand bagisciSilA4 = new NpgsqlCommand("delete from bagisci where kisino=@p1", baglanti);
                bagisciSilA4.Parameters.AddWithValue("@p1", int.Parse(txtKisiNo.Text));
                bagisciSilA4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("bagisci silindi;");

                baglanti.Open();
                NpgsqlCommand bagisciSilA2 = new NpgsqlCommand("delete from kisi where kisino=@p1", baglanti);
                bagisciSilA2.Parameters.AddWithValue("@p1", int.Parse(txtKisiNo.Text));
                bagisciSilA2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("kisi silindi;");

                baglanti.Open();
                NpgsqlCommand bagisciSilA5 = new NpgsqlCommand("delete from bagisciadres where adresno=@p1", baglanti);
                bagisciSilA5.Parameters.AddWithValue("@p1", int.Parse(txtAdresNo.Text));
                bagisciSilA5.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("adres silindi;");

                //bagisci sil
                baglanti.Open();
                NpgsqlCommand bagisciSilA3 = new NpgsqlCommand("delete from adres where adresno=@p1", baglanti);
                bagisciSilA3.Parameters.AddWithValue("@p1", int.Parse(txtAdresNo.Text));
                bagisciSilA3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("adres silindi;");   */

            }
            if (rdbBagisSil.Checked == true)
            {
                baglanti.Open();
                NpgsqlCommand bagisSilA1 = new NpgsqlCommand("delete from bagis where bagisno=@p1", baglanti);
                bagisSilA1.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                bagisSilA1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("bagis silindi;");

                baglanti.Open();
                string adresNo= " ";
                NpgsqlCommand bagisSilA3 = new NpgsqlCommand("select adresno from bagisadres where bagisno=@p1", baglanti);
                bagisSilA3.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                NpgsqlDataReader reader = bagisSilA3.ExecuteReader();
                while (reader.Read())
                {
                    adresNo = reader[0].ToString();
                }
                baglanti.Close();
                MessageBox.Show("bagis adres alindi;");

                baglanti.Open();
                NpgsqlCommand bagisSilA2 = new NpgsqlCommand("delete from adres where adresno=@p1", baglanti);
                bagisSilA2.Parameters.AddWithValue("@p1", int.Parse(adresNo));
                bagisSilA2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("bagis adres silindi;");

            }
            if (rdbBagisciGuncelle.Checked == true)
            {
                baglanti.Open();
                NpgsqlCommand bagisciGuncelleA1 = new NpgsqlCommand("update kisi set kisiad=@p1, kisisoyad=@p2, iletisimno=@p3 where kisino=@p4", baglanti);
                bagisciGuncelleA1.Parameters.AddWithValue("@p1", txtAdi.Text);
                bagisciGuncelleA1.Parameters.AddWithValue("@p2", txtSoyadi.Text);
                bagisciGuncelleA1.Parameters.AddWithValue("@p3", int.Parse(txtIletisimNo.Text));
                bagisciGuncelleA1.Parameters.AddWithValue("@p4", int.Parse(txtKisiNo.Text));
                bagisciGuncelleA1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("kisi guncellendi");
            }

            if (rdbBagisGuncelle.Checked == true)
            {

                baglanti.Open();
                string adresNo = " ";
                NpgsqlCommand bagisGuncelleA2 = new NpgsqlCommand("select adresno from bagis where bagisno=@p1", baglanti);
                bagisGuncelleA2.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                NpgsqlDataReader reader = bagisGuncelleA2.ExecuteReader();
                while (reader.Read())
                {
                    adresNo = reader[0].ToString();
                }
                baglanti.Close();
                MessageBox.Show("bagis adres no alındı;");

                baglanti.Open();
                NpgsqlCommand bagisGuncelleA1 = new NpgsqlCommand("update bagisadres set bagistur=@p1 where adresno=@p2", baglanti);
                bagisGuncelleA1.Parameters.AddWithValue("@p1", cmbBagisTur.SelectedItem);
                bagisGuncelleA1.Parameters.AddWithValue("@p2", int.Parse(adresNo));
                bagisGuncelleA1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("bagisadres guncellendi");

                baglanti.Open();
                string bagisTuru = " ";
                NpgsqlCommand bagisGuncelleA5 = new NpgsqlCommand("select bagistur from bagis where bagisno=@p1", baglanti);
                bagisGuncelleA5.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                NpgsqlDataReader reader1 = bagisGuncelleA5.ExecuteReader();
                while (reader1.Read())
                {
                    bagisTuru = reader1[0].ToString();
                }
                baglanti.Close();
                MessageBox.Show("bagis tur alındı;");

               
                string iletisimNo = " ";
                

                if (bagisTuru=="SU KUYUSU")
                {

                    //NpgsqlCommand bagisGuncelleA9 = new NpgsqlCommand("select iletisimno from sukuyusu where bagisno=@p1", baglanti);
                    //bagisGuncelleA9.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                    //NpgsqlDataReader reader3 = bagisGuncelleA9.ExecuteReader();
                    //while (reader3.Read())
                    //{
                    //    iletisimNo = reader3[0].ToString();
                    //}
                    //baglanti.Close();
                    //MessageBox.Show("iletisimno alındı;");

                    baglanti.Open();
                    NpgsqlCommand bagisGuncelleA6 = new NpgsqlCommand("delete from sukuyusu where bagisno=@p1", baglanti);
                    bagisGuncelleA6.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                    bagisGuncelleA6.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("bagis tur silindi;");
                }
                else if (bagisTuru == "KURBAN")
                {
                    //NpgsqlCommand bagisGuncelleA9 = new NpgsqlCommand("select iletisimno kurban bagis where bagisno=@p1", baglanti);
                    //bagisGuncelleA9.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                    //NpgsqlDataReader reader3 = bagisGuncelleA9.ExecuteReader();
                    //while (reader3.Read())
                    //{
                    //    iletisimNo = reader3[0].ToString();
                    //}
                    //baglanti.Close();
                    //MessageBox.Show("iletisimno alındı;");

                    baglanti.Open();
                    NpgsqlCommand bagisGuncelleA6 = new NpgsqlCommand("delete from kurban where bagisno=@p1", baglanti);
                    bagisGuncelleA6.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                    bagisGuncelleA6.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("bagis tur silindi;");
                }
                else if (bagisTuru == "YETIM HAMILIGI")
                {
                    //NpgsqlCommand bagisGuncelleA9 = new NpgsqlCommand("select iletisimno from yetimhamiligi where bagisno=@p1", baglanti);
                    //bagisGuncelleA9.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                    //NpgsqlDataReader reader3 = bagisGuncelleA9.ExecuteReader();
                    //while (reader3.Read())
                    //{
                    //    iletisimNo = reader3[0].ToString();
                    //}
                    //baglanti.Close();
                    //MessageBox.Show("iletisimno alındı;");

                    baglanti.Open();
                    NpgsqlCommand bagisGuncelleA6 = new NpgsqlCommand("delete from yetimhamiligi where bagisno=@p1", baglanti);
                    bagisGuncelleA6.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                    bagisGuncelleA6.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("bagis tur silindi;");
                }
                else
                {
                    //NpgsqlCommand bagisGuncelleA9 = new NpgsqlCommand("select iletisimno from sadaka where bagisno=@p1", baglanti);
                    //bagisGuncelleA9.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                    //NpgsqlDataReader reader3 = bagisGuncelleA9.ExecuteReader();
                    //while (reader3.Read())
                    //{
                    //    iletisimNo = reader3[0].ToString();
                    //}
                    //baglanti.Close();
                    //MessageBox.Show("iletisimno alındı;");

                    baglanti.Open();
                    NpgsqlCommand bagisGuncelleA6 = new NpgsqlCommand("delete from sadaka where bagisno=@p1", baglanti);
                    bagisGuncelleA6.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                    bagisGuncelleA6.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("bagis tur silindi;");
                }

                baglanti.Open();
                string kisiNo = " ";
                NpgsqlCommand bagisGuncelleA8 = new NpgsqlCommand("select kisino from bagis where bagisno=@p1", baglanti);
                bagisGuncelleA8.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                NpgsqlDataReader reader2 = bagisGuncelleA8.ExecuteReader();
                while (reader2.Read())
                {
                    kisiNo = reader2[0].ToString();
                }
                baglanti.Close();
                MessageBox.Show("kisino alındı;");


                baglanti.Open();
                NpgsqlCommand bagisGuncelleA3 = new NpgsqlCommand("update bagis set bagistur=@p1 , miktar=@p2 where bagisno=@p3", baglanti);
                bagisGuncelleA3.Parameters.AddWithValue("@p1", cmbBagisTur.SelectedItem);
                bagisGuncelleA3.Parameters.AddWithValue("@p2", int.Parse(txtBagisMiktar.Text));
                bagisGuncelleA3.Parameters.AddWithValue("@p3", int.Parse(txtBagisNo.Text));
                bagisGuncelleA3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("bagis guncellendi");

                baglanti.Open();
                if (cmbBagisTur.SelectedIndex == 0)
                {
                    NpgsqlCommand bagisEkleA2 = new NpgsqlCommand("insert into sukuyusu (bagisno, kisino, iletisimno) values (@p1, @p2, @p3)", baglanti);
                    bagisEkleA2.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                    bagisEkleA2.Parameters.AddWithValue("@p2", int.Parse(kisiNo));
                    bagisEkleA2.Parameters.AddWithValue("@p3", 0);
                    bagisEkleA2.ExecuteNonQuery();
                }
                else if (cmbBagisTur.SelectedIndex == 1)
                {
                    NpgsqlCommand bagisEkleA2 = new NpgsqlCommand("insert into kurban (bagisno, kisino, iletisimno) values (@p1, @p2, @p3)", baglanti);
                    bagisEkleA2.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                    bagisEkleA2.Parameters.AddWithValue("@p2", int.Parse(kisiNo));
                    bagisEkleA2.Parameters.AddWithValue("@p3", 0);
                    bagisEkleA2.ExecuteNonQuery();
                }
                else if (cmbBagisTur.SelectedIndex == 2)
                {
                    NpgsqlCommand bagisEkleA2 = new NpgsqlCommand("insert into yetimhamiligi (bagisno, kisino, iletisimno) values (@p1, @p2, @p3)", baglanti);
                    bagisEkleA2.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                    bagisEkleA2.Parameters.AddWithValue("@p2", int.Parse(kisiNo));
                    bagisEkleA2.Parameters.AddWithValue("@p3", 0);
                    bagisEkleA2.ExecuteNonQuery();
                }
                else
                {
                    NpgsqlCommand bagisEkleA2 = new NpgsqlCommand("insert into sadaka (bagisno, kisino, iletisimno) values (@p1, @p2, @p3)", baglanti);
                    bagisEkleA2.Parameters.AddWithValue("@p1", int.Parse(txtBagisNo.Text));
                    bagisEkleA2.Parameters.AddWithValue("@p2", int.Parse(kisiNo));
                    bagisEkleA2.Parameters.AddWithValue("@p3", 0);
                    bagisEkleA2.ExecuteNonQuery();
                }
                baglanti.Close();
                MessageBox.Show("bagis turu eklendi");
            }
            if (rdbBagisciAra.Checked == true)
            {
                baglanti.Open();
                NpgsqlDataAdapter bagisciAra = new NpgsqlDataAdapter("select * from bagiscilistele where kisiad like '%" + txtAdi.Text + "%'  ", baglanti);
                DataTable tbl = new DataTable();
                bagisciAra.Fill(tbl);
                dataGridView1.DataSource = tbl;
                baglanti.Close();          
            }
            if (rdbBagisAra.Checked == true)
            {
                baglanti.Open();
                NpgsqlDataAdapter bagisAra = new NpgsqlDataAdapter("select * from bagislistele where bagistur like '%" + cmbBagisTur.SelectedItem + "%'  ", baglanti);
                DataTable tbl = new DataTable();
                bagisAra.Fill(tbl);
                dataGridView1.DataSource = tbl;
                baglanti.Close();
            }
        }
        //cikis
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        //bagisci listele
        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from bagislistesi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        //kisi listele
        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from bagiscilistele";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void rdbBagisciGuncelle_CheckedChanged(object sender, EventArgs e)
        {
            sayfayiTemizle();
            MessageBox.Show("kisino guncellenemez.");
            txtAdi.ReadOnly = false; txtSoyadi.ReadOnly = false; txtIletisimNo.ReadOnly = false;
            txtAdresNo.ReadOnly = true; txtBolge.ReadOnly = true; txtSehir.ReadOnly = true; txtUlke.ReadOnly = true;
            txtBagisNo.ReadOnly = true; txtBagisMiktar.ReadOnly = true; txtTelefon.ReadOnly = false;
            txtBagisUlke.ReadOnly = true; txtBagisAdresNo.ReadOnly = true; txtKisiNo.ReadOnly = false;
        }

        private void rdbBagisciSil_CheckedChanged(object sender, EventArgs e)
        {
            sayfayiTemizle();
            txtAdi.ReadOnly = true; txtSoyadi.ReadOnly = true; txtIletisimNo.ReadOnly = true;
            txtAdresNo.ReadOnly = false; txtBolge.ReadOnly = true; txtSehir.ReadOnly = true; txtUlke.ReadOnly = true;
            txtBagisNo.ReadOnly = true; txtBagisMiktar.ReadOnly = true; txtTelefon.ReadOnly = true;
            txtBagisUlke.ReadOnly = true; txtBagisAdresNo.ReadOnly = true; txtKisiNo.ReadOnly = false;
        }

        private void rdbBagisSil_CheckedChanged(object sender, EventArgs e)
        {
            sayfayiTemizle();
            txtAdi.ReadOnly = true; txtSoyadi.ReadOnly = true; txtIletisimNo.ReadOnly = true;
            txtAdresNo.ReadOnly = true; txtBolge.ReadOnly = true; txtSehir.ReadOnly = true; txtUlke.ReadOnly = true;
            txtBagisNo.ReadOnly = false; txtBagisMiktar.ReadOnly = true; txtTelefon.ReadOnly = true;
            txtBagisUlke.ReadOnly = true; txtBagisAdresNo.ReadOnly = false; txtKisiNo.ReadOnly = true;
        }

        private void rdbBagisGuncelle_CheckedChanged(object sender, EventArgs e)
        {
            sayfayiTemizle();
            txtAdi.ReadOnly = true; txtSoyadi.ReadOnly = true; txtIletisimNo.ReadOnly = true;
            txtAdresNo.ReadOnly = true; txtBolge.ReadOnly = true; txtSehir.ReadOnly = true; txtUlke.ReadOnly = true;
            txtBagisNo.ReadOnly = false; txtBagisMiktar.ReadOnly = false; txtTelefon.ReadOnly = true;
            txtBagisUlke.ReadOnly = true; txtBagisAdresNo.ReadOnly = true; txtKisiNo.ReadOnly = true;
        }

        private void rdbBagisciAra_CheckedChanged(object sender, EventArgs e)
        {
            txtAdi.ReadOnly = false; txtSoyadi.ReadOnly = true; txtIletisimNo.ReadOnly = true;
            txtAdresNo.ReadOnly = true; txtBolge.ReadOnly = true; txtSehir.ReadOnly = true; txtUlke.ReadOnly = true;
            txtBagisNo.ReadOnly = true; txtBagisMiktar.ReadOnly = true; txtTelefon.ReadOnly = true;
            txtBagisUlke.ReadOnly = true; txtBagisAdresNo.ReadOnly = true; txtKisiNo.ReadOnly = true;
        }

        private void rdbBagisAra_CheckedChanged(object sender, EventArgs e)
        {
            txtAdi.ReadOnly = true; txtSoyadi.ReadOnly = true; txtIletisimNo.ReadOnly = true;
            txtAdresNo.ReadOnly = true; txtBolge.ReadOnly = true; txtSehir.ReadOnly = true; txtUlke.ReadOnly = true;
            txtBagisNo.ReadOnly = true; txtBagisMiktar.ReadOnly = true; txtTelefon.ReadOnly = true;
            txtBagisUlke.ReadOnly = true; txtBagisAdresNo.ReadOnly = true; txtKisiNo.ReadOnly = true;
        }
    }
}
