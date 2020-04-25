using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
        }
        private void VoyageListDetailKapatbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
