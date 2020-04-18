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

        private void PastVoyageListbtn_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
            
        }

        private void PastVoyageListCancelbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
