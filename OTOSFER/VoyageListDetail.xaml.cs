using OTOSFER.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
using System.Windows.Shapes;
using static OTOSFER.Classes.Node;

namespace OTOSFER
{
    /// <summary>
    /// Interaction logic for VoyageListDetail.xaml
    /// </summary>
    public partial class VoyageListDetail : Window
    {
        DoubleLinkedList dllist = new DoubleLinkedList();
        DoubleLinkedList dllist1 = new DoubleLinkedList();
        public VoyageListDetail()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VoyageListDetailtarihtxt.IsEnabled = false;
            VoyageListDetailsaattxt.IsEnabled = false;
            VoyageListDetailbiletfiyatitxt.IsEnabled = false;
            VoyageListDetailguzergahtxt.IsEnabled = false;
            VoyageListDetailkaptantxt.IsEnabled = false;
            VoyageListDetailplakatxt.IsEnabled = false;
            VoyageListDetailyolcukapasitesitxt.IsEnabled = false;
            VoyageListDetailsefernotxt.IsEnabled = false;
        }

        private void VoyageListDetailDuzenlebtn_Click(object sender, RoutedEventArgs e)
        {
            VoyageListDetailtarihtxt.IsEnabled = true;
            VoyageListDetailsaattxt.IsEnabled = true;
            VoyageListDetailbiletfiyatitxt.IsEnabled = true;
            VoyageListDetailguzergahtxt.IsEnabled = true;
            VoyageListDetailkaptantxt.IsEnabled = true;
            VoyageListDetailplakatxt.IsEnabled = true;
            VoyageListDetailyolcukapasitesitxt.IsEnabled = true;
            VoyageListDetailsefernotxt.IsEnabled = true;
            VoyageListDetailGuncellebtn.IsEnabled = true;
            VoyageListDetailDuzenlebtn.IsEnabled = false;
        }
        private void VoyageListDetailKapatbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void VoyageListDetailSilbtn_Click(object sender, RoutedEventArgs e)
        {
            /*if (MessageBox.Show("Seferi Silmek İstediğinize Emin Misiniz ?", "Onay", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {

                Globals.silinecekseferno = Convert.ToInt32(VoyageListDetailsefernotxt.Text);
                Globals.silineceksefertarih = VoyageListDetailtarihtxt.Text;

               using (StreamReader sr = new StreamReader("C:\\Users\\akinb\\OneDrive\\Masaüstü\\"+ Globals.silineceksefertarih + ".txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if ((line[line.Length - 1]) == ';')
                        {
                            dllist.AddNode(line);

                        }
                    }
                    sr.Close();
                }

                Node node = dllist.First;
                while (node != null)
                {
                    if (node.previous == null && node.SeferNo == Globals.seferno)
                    {
                        node.next.previous = null;
                    }
                    else if (node.SeferNo == Globals.seferno)
                    {
                        
                        node.next.previous = node.previous;
                        node.previous.next = node.next;
                    }
                    else if (node.next == null && node.SeferNo == Globals.seferno)
                    {
                        node.previous.next = null;
                    }

                    node = node.next;
                }

                using (StreamWriter sw = File.AppendText("C:\\Users\\akinb\\OneDrive\\Masaüstü\\" + Globals.silineceksefertarih + ".txt"))
                {
                    while (node != null)
                    {
                        sw.Write(node.Data + Environment.NewLine);
                        node = node.next;
                    }
                    sw.Close();
                }


                using (StreamReader sr = new StreamReader(Globals.tumseferyolu))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {

                        if ((line[line.Length - 1]) == ';')
                        {
                            dllist1.AddNode(line);
                        }
                    }
                    sr.Close();
                }

                Node node1 = dllist1.First;
                while (node1 != null)
                {
                    if (node1.previous == null && node1.SeferNo == Globals.seferno)
                    {
                        node1.next.previous = null;
                    }
                    else if (node1.SeferNo == Globals.seferno)
                    {
                       
                        node1.next.previous = node1.previous;
                        node1.previous.next = node1.next;
                    }
                    else if (node1.next == null && node1.SeferNo == Globals.seferno)
                    {
                        node1.previous.next = null;
                    }

                    node1 = node1.next;
                }

                using (StreamWriter sw = File.AppendText(Globals.tumseferyolu)) 
                {
                    while (node != null)
                    {
                        sw.Write(node.Data+Environment.NewLine);
                        node = node.next;
                    }
                    sw.Close();
                }
                MessageBox.Show("Silme işlemi başarılı");
            }*/
        }
        private void VoyageListDetailGuncellebtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

