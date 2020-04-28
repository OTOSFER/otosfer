using OTOSFER.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OTOSFER
{

    public partial class VoyageAddUc : UserControl
    {
        CiftYonluBagliListe Sefereklelist = new CiftYonluBagliListe();
        CiftYonluBagliListee Koltuklist = new CiftYonluBagliListee();
        public VoyageAddUc()
        {
            InitializeComponent();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void VoyageAddbtn_Click(object sender, RoutedEventArgs e)
        {
            string ts = VoyageAddTarihtxt.Text +".txt";
            string path = "C:\\Users\\Lenovo\\Desktop\\" + ts;
            

             if (VoyageAddGuzergahcmb.SelectedIndex == -1)
                 MessageBox.Show("Güzergah Seçilmelidir");
             else if (VoyageAddBiletFiyatitxt.Text == "")
                 MessageBox.Show("Bilet Fiyatı Boş Bırakılmamalıdır");
             else if (VoyageAddPlakacmb.SelectedIndex == -1)
                 MessageBox.Show("Plaka Seçilmelidir");
             else if (VoyageAddKaptancmb.SelectedIndex == -1)
                 MessageBox.Show("Kaptan Seçilmelidir");
             else if (VoyageAddYolcuKapasitesitxt.Text == "")
                 MessageBox.Show("Yolcu Kapasitesi Girilmelidir");
             else if (VoyageAddTarihtxt.Text == "")
                 MessageBox.Show("Tarih Boş Geçilmemelidir");
             else if (VoyageAddSaattxt.Text == "")
                 MessageBox.Show("Saat Boş Geçilmemelidir");
             else
             {
                if (MessageBox.Show("Seferi Eklemek İstediğinize Emin Misiniz ?", "Onay", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    //Koltuk listesi oluşturma
                    for (int i=1;i<=Convert.ToInt32(VoyageAddYolcuKapasitesitxt.Text);i++) 
                    {
                        Koltuklist.Ekle(i.ToString(),VoyageAddBiletFiyatitxt.Text," "," ","Boş");
                    }

                    //Seferlistesine Seferi Ekleme
                    Sefereklelist.SeferEkle(Globals.seferno.ToString(),VoyageAddTarihtxt.Text,VoyageAddSaattxt.Text,VoyageAddGuzergahcmb.Text,VoyageAddKaptancmb.Text,VoyageAddPlakacmb.Text,VoyageAddYolcuKapasitesitxt.Text,VoyageAddBiletFiyatitxt.Text,Koltuklist.ilk);
                    
                    //Oluşturulan Sefer Tarihli dosya oluşturma
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sws = File.CreateText(path))
                        {
                            sws.Close();
                        }
                    }
                    //Oluşturulan Sefer Tarihli txtye seferi listeden ekleme
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        SeferDugum gecici = Sefereklelist.Seferson;
                        sw.Write(gecici.SeferNo+"-"+gecici.Tarih+"-"+gecici.Saat+"-"+gecici.Guzergah+"-"+gecici.Kaptan+"-"+gecici.Plaka+"-"+gecici.Kapasite+"-"+gecici.BiletFiyati+";");
                        sw.Write(Environment.NewLine);
                        sw.Close();
                    }
                    //Oluşturulan Sefere ait Koltuk bilgilerini txtye listeden ekleme
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        Dugum gecici = Koltuklist.ilk;
                        while(gecici != null)
                        {
                            sw.Write(gecici.KoltukNo + "-" + gecici.Fiyat + "-" + gecici.AdSoyad + "-" + gecici.Cinsiyet + "-" + gecici.Durum + "-");
                            sw.Write(Environment.NewLine);
                            gecici = gecici.Sonraki;
                        }
                        sw.Close();
                    }
                    //Oluşturlan Seferin ve Koltul Bilgisinin Tüm Seferlere Eklenmesi
                    if (!File.Exists(Globals.tumseferyolu))
                    {
                        using (StreamWriter swtsy = File.CreateText(Globals.tumseferyolu))
                        {
                            swtsy.Close();
                        }
                    }
                    using (StreamWriter swtsy = File.AppendText(Globals.tumseferyolu))
                    {
                        SeferDugum gecici = Sefereklelist.Seferson;
                        swtsy.Write(gecici.SeferNo + "-" + gecici.Tarih + "-" + gecici.Saat + "-" + gecici.Guzergah + "-" + gecici.Kaptan + "-" + gecici.Plaka + "-" + gecici.Kapasite + "-" + gecici.BiletFiyati + "-");
                        swtsy.Write(Environment.NewLine);
                        swtsy.Close();
                    }

                    using (StreamWriter sw = File.AppendText(Globals.tumseferyolu))
                    {
                        Dugum gecici = Koltuklist.ilk;
                        while (gecici != null)
                        {
                            sw.Write(gecici.KoltukNo + "-" + gecici.Fiyat + "-" + gecici.AdSoyad + "-" + gecici.Cinsiyet + "-" + gecici.Durum + "-");
                            sw.Write(Environment.NewLine);
                            gecici = gecici.Sonraki;
                        }
                        sw.Close();
                    }
                    Globals.seferno++;
                    Koltuklist.Temizle();
                    MessageBox.Show("İşlem Başarılı");
                }


            }
            
        }

       
    }
}
