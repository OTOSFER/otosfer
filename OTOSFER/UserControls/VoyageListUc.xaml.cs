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
    /// Interaction logic for VoyageListUc.xaml
    /// </summary>
    public partial class VoyageListUc : UserControl
    {
        List<items> it = new List<items>();
        public VoyageListUc()
        {
            InitializeComponent();
        }

        private void vluc_Loaded(object sender, RoutedEventArgs e)
        {
            it.Add(new items { sno = 1, gzg = "Kocaeli-İstanbul", tvs = "10.12.2020-14:55" });
            it.Add(new items { sno = 2, gzg = "Kocaeli-Ankara", tvs = "11.12.2020-19:55" });
            it.Add(new items { sno = 3, gzg = "Kocaeli-İzmir", tvs = "12.12.2020-20:55" });
            VoyageListdg.ItemsSource=it;
        }
        class items
        {
            public int sno { get; set; }
            public string gzg { get; set; }
            public string tvs { get; set; }
        }
    }
}
