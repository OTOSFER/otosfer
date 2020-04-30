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
using static OTOSFER.Classes.Node;

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
        DoubleLinkedList dllist = new DoubleLinkedList();

        public VoyageListUc()
        {
            InitializeComponent();
        }



        private void vluc_Loaded(object sender, RoutedEventArgs e)
        {
            Globals.vldg = VoyageListdg;
           
            using (StreamReader sr = new StreamReader("C:\\Users\\akinb\\OneDrive\\Masaüstü\\" + Globals.gununtarihi + ".txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    
                    if ((line[line.Length-1]) == ';')
                    {
                        
                        dllist.AddNode(line);
                       
                    }
                }

                Node node = dllist.First;
                while(node != null)
                {
                    
                    vlit.Add(new Items { sno = node.SeferNo, t = node.Tarih, s = node.Saat, gzr = node.Guzergah, k = node.Kaptan, p = node.Plaka, yk = node.Kapasite, bf = node.BiletFiyati });
                    
                    node = node.next;
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
                    vld.VoyageListDetailguzergahtxt.Text = abc.gzr;
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
