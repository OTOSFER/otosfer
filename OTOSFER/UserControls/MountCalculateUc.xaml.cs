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
using static OTOSFER.Classes.Node.Node1;

namespace OTOSFER.UserControls
{
    
    
    public partial class MountCalculateUc : UserControl
    {
        int Gelir = 0;
        int sayac = 0;
        int biletfiyat;
        int kapasite;
        int i = 1;
        public MountCalculateUc()
        {
            InitializeComponent();
        }

        private void mcuc_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleLinkedList dllist = new DoubleLinkedList();
            DoubleLinkedList1 dllist1 = new DoubleLinkedList1();
            Node1 node1 = dllist1.First;
            using (StreamReader sr=new StreamReader("C:\\Users\\akinb\\OneDrive\\Masaüstü\\"+Globals.gelirhesaplamatarihi+".txt")) 
            {
                string line;
                while ((line = sr.ReadLine())!= null)
                {
                    if (line[line.Length - 1] == ';')
                    {
                        dllist.AddNode(line);

                        biletfiyat = Convert.ToInt32(dllist.Last.BiletFiyati);
                        kapasite = Convert.ToInt32(dllist.Last.Kapasite);

                    }
                    else if (line[line.Length - 1] == '-')
                        {
                            dllist1.AddNode1(line);
                            if(i==kapasite)
                            {
                                while(node1!=null && node1.Durum == "Dolu")
                                {
                                    sayac++;
                                    node1 = node1.next;
                                }
                            }
                            Gelir += sayac * biletfiyat;
                             i++;
                        }
                  
                   
                    
                }
                sr.Close();
            }
            Node node = dllist.First;
            while (node !=null)
            {
                if(node.Otobus.Durum =="Dolu")
                {
                    sayac++;
                }
                node = node.next;
            }
            Gelir = sayac * Convert.ToInt32(node.BiletFiyati);

            mountcalculatetarihlbl.Content = Globals.gelirhesaplamatarihi;
            mountcalculatepricelbl.Content = Gelir.ToString();
        }
    }
}
