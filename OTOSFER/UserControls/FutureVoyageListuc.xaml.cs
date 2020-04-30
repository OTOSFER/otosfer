using OTOSFER.Classes;
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
using static OTOSFER.Classes.Node;

namespace OTOSFER.UserControls
{
    public partial class FutureVoyageListuc : UserControl
    {
        List<Items> fvlit = new List<Items>();
        DoubleLinkedList dllist = new DoubleLinkedList();
        public FutureVoyageListuc()
        {
            InitializeComponent();
        }

        private void fvluc_Loaded(object sender, RoutedEventArgs e)
        {
            
            using (StreamReader sr = new StreamReader("C:\\Users\\akinb\\OneDrive\\Masaüstü\\" + Globals.gelecekguntarihi + ".txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {

                    if ((line[line.Length - 1]) == ';')
                    {

                        dllist.AddNode(line);
                    }
                }

                Node node = dllist.First;
                while (node != null)
                {
                    fvlit.Add(new Items { sno = node.SeferNo, t = node.Tarih, s = node.Saat, gzr = node.Guzergah, k = node.Kaptan, p = node.Plaka, yk = node.Kapasite, bf = node.BiletFiyati });
                    node = node.next;
                }

                FutureVoyageListdg.ItemsSource = "null";

                FutureVoyageListdg.ItemsSource = fvlit;

            }
        }
    }
}
