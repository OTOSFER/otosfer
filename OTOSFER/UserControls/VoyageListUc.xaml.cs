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
    /// Interaction logic for VoyageListUc.xaml
    /// </summary>
    public partial class VoyageListUc : UserControl
    {
        List<items> it = new List<items>();
        string temp;
        string[] yuklenecek = new string[8];
        public VoyageListUc()
        {
            InitializeComponent();
        }



        private void vluc_Loaded(object sender, RoutedEventArgs e)
        {
            
            using (StreamReader sr = new StreamReader("C:\\Users\\Lenovo\\Desktop\\" + Globals.gununtarihi + ".txt"))
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
                            temp += line[i].ToString();
                        }
                        else
                        {
                            yuklenecek[j] = temp;
                            temp = "";
                            j++;
                            if (j == yuklenecek.Length)
                                j = 0;
                        }
                        i++;
                    }
                    i = 0;
                    it.Add(new items { t = yuklenecek[0], s = yuklenecek[1], ky = yuklenecek[2], vy = yuklenecek[3], k = yuklenecek[4], p = yuklenecek[5], yk = yuklenecek[6], bf = yuklenecek[7] });
   
                }
                VoyageListdg.ItemsSource = "null";
                
                VoyageListdg.ItemsSource = it;

            }
        }
        class items
        {
            public int sno { get; set; }
            public string t { get; internal set; }
            public string s { get; internal set; }
            public string ky { get; internal set; }
            public string vy { get; internal set; }
            public string k { get; internal set; }
            public string p { get; internal set; }
            public string yk { get; internal set; }
            public string bf { get; internal set; }
        }
    }
}
