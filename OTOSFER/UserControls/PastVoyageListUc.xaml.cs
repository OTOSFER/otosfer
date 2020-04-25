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

namespace OTOSFER.UserControls
{
    /// <summary>
    /// Interaction logic for PastVoyageListUc.xaml
    /// </summary>
    public partial class PastVoyageListUc : UserControl
    {
        List<Items> pvlit = new List<Items>();
        string pvltemp;
        string[] pvlyuklenecek = new string[8];
        public PastVoyageListUc()
        {
            InitializeComponent();
        }

        private void pvluc_Loaded(object sender, RoutedEventArgs e)
        {
            Globals.gecmisguntarihi = "22.04.2020";
            using (StreamReader sr = new StreamReader("C:\\Users\\Lenovo\\Desktop\\" + Globals.gecmisguntarihi + ".txt"))
            {
                string line;
                int i = 0;
                int j = 0;


                while ((line = sr.ReadLine()) != null)
                {


                    while (i != line.Length)
                    {

                        if (line[i] != '-')
                        {
                            pvltemp += line[i].ToString();
                        }
                        else
                        {
                            pvlyuklenecek[j] = pvltemp;
                            pvltemp = "";
                            j++;
                            if (j == pvlyuklenecek.Length)
                                j = 0;
                        }
                        i++;
                    }
                    i = 0;
                    pvlit.Add(new Items { t = pvlyuklenecek[0], s = pvlyuklenecek[1], ky = pvlyuklenecek[2], vy = pvlyuklenecek[3], k = pvlyuklenecek[4], p = pvlyuklenecek[5], yk = pvlyuklenecek[6], bf = pvlyuklenecek[7] });

                }
                PastVoyageListdg.ItemsSource = "null";

                PastVoyageListdg.ItemsSource = pvlit;

            }

        }
    }
}
