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
    /// Interaction logic for ChooseDateForPastVoyageList.xaml
    /// </summary>
    public partial class ChooseDateForPastVoyageList : Window
    {
       
        
        public ChooseDateForPastVoyageList()
        {
            InitializeComponent();
            
        }

        public void PastVoyageListbtn_Click(object sender, RoutedEventArgs e)
        {
            
            Globals.gecmisguntarihi = pastvoyagedatecmb.Text;
            CallUserControls.Add_Uc(Globals.grd, new PastVoyageListUc());
            this.Close();
            
        }

        private void PastVoyageListCancelbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
