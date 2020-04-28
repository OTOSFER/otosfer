using OTOSFER.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
using System.Windows.Shapes;

namespace OTOSFER
{
    /// <summary>
    /// Interaction logic for VoyageListDetail.xaml
    /// </summary>
    public partial class VoyageListDetail : Window
    {
        public VoyageListDetail()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VoyageListDetailtarihtxt.IsEnabled = false;
            VoyageListDetailsaattxt.IsEnabled = false;
            VoyageListDetailbiletfiyatitxt.IsEnabled = false;
            VoyageListDetailkalkisyeritxt.IsEnabled = false;
            VoyageListDetailkaptantxt.IsEnabled = false;
            VoyageListDetailplakatxt.IsEnabled = false;
            VoyageListDetailvarisyeritxt.IsEnabled = false;
            VoyageListDetailyolcukapasitesitxt.IsEnabled = false;
            VoyageListDetailsefernotxt.IsEnabled = false;
        }

        private void VoyageListDetailDuzenlebtn_Click(object sender, RoutedEventArgs e)
        {
            VoyageListDetailtarihtxt.IsEnabled = true;
            VoyageListDetailsaattxt.IsEnabled = true;
            VoyageListDetailbiletfiyatitxt.IsEnabled = true;
            VoyageListDetailkalkisyeritxt.IsEnabled = true;
            VoyageListDetailkaptantxt.IsEnabled = true;
            VoyageListDetailplakatxt.IsEnabled = true;
            VoyageListDetailvarisyeritxt.IsEnabled = true;
            VoyageListDetailyolcukapasitesitxt.IsEnabled = true;
            VoyageListDetailsefernotxt.IsEnabled = true;
        }
        private void VoyageListDetailKapatbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void VoyageListDetailSilbtn_Click(object sender, RoutedEventArgs e)
        {
            string silineceksefertarih = VoyageListDetailtarihtxt.Text;
            int silinecekseferno = Convert.ToInt32(VoyageListDetailsefernotxt.Text);

            if (MessageBox.Show("Seferi Silmek İstediğinize Emin Misiniz ?", "Onay", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {

                List<string> alinanveri = File.ReadAllLines("C:\\Users\\Lenovo\\Desktop\\" + silineceksefertarih + ".txt").ToList();
                alinanveri.RemoveAt(silinecekseferno);
                File.WriteAllLines("C:\\Users\\Lenovo\\Desktop\\" + silineceksefertarih + ".txt", alinanveri.ToArray());
                MessageBox.Show("İşlem Başarılı");
                this.Close();
            }

        }
    }
}

