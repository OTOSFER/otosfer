using OTOSFER.Classes;
using OTOSFER.UserControls;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for ChooseDateForFutureVoyageList.xaml
    /// </summary>
    public partial class ChooseDateForFutureVoyageList : Window
    {
        public ChooseDateForFutureVoyageList()
        {
            InitializeComponent();
        }

        private void FutureVoyageListbtn_Click(object sender, RoutedEventArgs e)
        {
            Globals.gelecekguntarihi = futurevoyagedatecmb.Text;
            CallUserControls.Add_Uc(Globals.grd, new FutureVoyageListuc());
            this.Close();
        }

        private void FutureVoyageListCancelbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
     
    }
}
