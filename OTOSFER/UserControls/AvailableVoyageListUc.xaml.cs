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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OTOSFER.UserControls
{
    /// <summary>
    /// Interaction logic for AvailableVoyageListUc.xaml
    /// </summary>
    public partial class AvailableVoyageListUc : UserControl
    {
        List<items> it = new List<items>();
        public AvailableVoyageListUc()
        {
            InitializeComponent();
        }
        class items
        {
            public int sno { get; set; }
            public string gzg { get; set; }
            public string tvs { get; set; }
        }

        private void AvailableVoyageListdg_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void avluc_Loaded(object sender, RoutedEventArgs e)
        {
            it.Add(new items { sno = 1, gzg = "Kocaeli-İstanbul", tvs = "10.12.2020-14:55" });
            it.Add(new items { sno = 2, gzg = "Kocaeli-Ankara", tvs = "11.12.2020-19:55" });
            it.Add(new items { sno = 3, gzg = "Kocaeli-İzmir", tvs = "12.12.2020-20:55" });
            AvailableVoyageListdg.ItemsSource = it;
        }

        private void AvailableVoyageListdg_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            DataForChoosenVoyage dfcv = new DataForChoosenVoyage();
            dfcv.Show();
        }
    }
}
