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
    /// Interaction logic for DataForChoosenVoyage.xaml
    /// </summary>
    public partial class DataForChoosenVoyage : Window
    {
        public DataForChoosenVoyage()
        {
            InitializeComponent();
        }

        private void Koltuk1btn_Click(object sender, RoutedEventArgs e)
        {
            TicketOperation to = new TicketOperation();
            to.Show();
            this.Close();

        }
    }
}
