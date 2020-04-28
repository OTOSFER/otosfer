using OTOSFER.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        List<Items> vlit = new List<Items>();
        string vltemp;
        string[] vlyuklenecek = new string[9];
        
        public VoyageListUc()
        {
            InitializeComponent();
        }



        private void vluc_Loaded(object sender, RoutedEventArgs e)
        {
            Globals.vldg = VoyageListdg;
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
                            if (line[i] !=';')
                            vltemp += line[i].ToString();
                        }
                        else
                        {
                            vlyuklenecek[j] = vltemp;
                            vltemp = "";
                            j++;
                            if (j == vlyuklenecek.Length)
                                j = 0;
                        }

                        i++;
                    }
                    i = 0;

                    if (line[line.Length - 1] == ';')
                        vlit.Add(new Items { sno = Convert.ToInt32(vlyuklenecek[0]), t = vlyuklenecek[1], s = vlyuklenecek[2], gzr = vlyuklenecek[3], k = vlyuklenecek[4], p = vlyuklenecek[5], yk = vlyuklenecek[6], bf = vlyuklenecek[7] });
                    
                    


                }
                VoyageListdg.ItemsSource = "null";
                
                VoyageListdg.ItemsSource = vlit;

            }
        }

        private void VoyageListdg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = 0;
            VoyageListDetail vld = new VoyageListDetail();
            foreach (var abc in vlit) 
            {   
                if(i==VoyageListdg.SelectedIndex)
                {
                    vld.VoyageListDetailsefernotxt.Text =(abc.sno).ToString();
                    vld.VoyageListDetailtarihtxt.Text = abc.t;
                    vld.VoyageListDetailsaattxt.Text = abc.s;
                    vld.VoyageListDetailkalkisyeritxt.Text = abc.gzr;
                    vld.VoyageListDetailkaptantxt.Text = abc.k;
                    vld.VoyageListDetailplakatxt.Text = abc.p;
                    vld.VoyageListDetailyolcukapasitesitxt.Text = abc.yk;
                    vld.VoyageListDetailbiletfiyatitxt.Text = abc.bf;
                }
                i++;
            }
            vld.ShowDialog();
            
    
        }
    }
}
