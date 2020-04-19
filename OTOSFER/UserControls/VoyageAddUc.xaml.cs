using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    /// <summary>
    /// VoyageAddUc.xaml etkileşim mantığı
    /// </summary>
    public partial class VoyageAddUc : UserControl
    {
        int i = 0;
        public VoyageAddUc()
        {
            InitializeComponent();
        }

        private void VoyageAddbtn_Click(object sender, RoutedEventArgs e)
        {
            string ts = VoyageAddTarihtxt.Text +".txt";
            string path = "C:\\Users\\Lenovo\\Desktop\\"+ ts;

            

             if (VoyageAddKalkisYericmb.SelectedIndex == -1)
                 MessageBox.Show("Kalkış Yeri Seçilmelidir");
             else if (VoyageAddVarisYericmb.SelectedIndex == -1)
                 MessageBox.Show("Varış Yeri Seçilmelidir");
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
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sws = File.CreateText(path))
                        {

                        }

                    }
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(VoyageAddTarihtxt.Text + " " + VoyageAddSaattxt.Text + " " + VoyageAddKalkisYericmb.Text + " " + VoyageAddVarisYericmb.Text + " " + VoyageAddKaptancmb.Text + " " + VoyageAddPlakacmb.Text + " " + VoyageAddYolcuKapasitesitxt.Text + " " + VoyageAddBiletFiyatitxt.Text);

                    }

                }


            }
            
        }       
    }
}
