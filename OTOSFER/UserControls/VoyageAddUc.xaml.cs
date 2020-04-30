using OTOSFER.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
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

namespace OTOSFER
{

    public partial class VoyageAddUc : UserControl
    {
        DoubleLinkedList VoyageDLList = new DoubleLinkedList();
        DoubleLinkedList1 SeatDLList = new DoubleLinkedList1();
        string line;
        string line1;
        int i = 0;
        int j = 0;
        int k = 0;
        string temp = "";

        public VoyageAddUc()
        {
            InitializeComponent();
        }
        private void vauc_Loaded(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(Globals.tumseferyolu))
            {
                using (StreamWriter sws = File.CreateText(Globals.tumseferyolu))
                {
                    sws.Close();
                }
            }
            using (StreamReader sr = new StreamReader(Globals.tumseferyolu))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    j++;

                }
                sr.Close();
            }
            using (StreamReader sr = new StreamReader(Globals.tumseferyolu))
            { 
                while ((line1 =sr.ReadLine()) != null)
                {
                    
                    if (k != j-1)
                        k++;
                    else
                    {
                        while (i != line1.Length)
                        {
                            if (line1[i] != '-')
                            {
                                temp += line1[i].ToString();
                                
                            }
                            else
                                break;
                            i++;
                        }
                    }
     
                }
                if (temp != "")
                { Globals.seferno = Convert.ToInt32(temp)+1; }
                
                sr.Close();
            }
        }

        private void VoyageAddbtn_Click(object sender, RoutedEventArgs e)
        {
            string ts = VoyageAddTarihtxt.Text +".txt";
            string path = "C:\\Users\\akinb\\OneDrive\\Masaüstü\\" + ts;
            

             if (VoyageAddGuzergahcmb.SelectedIndex == -1)
                 MessageBox.Show("Güzergah Seçilmelidir");
             else if (VoyageAddBiletFiyatitxt.Text == "")
                 MessageBox.Show("Bilet Fiyatı Boş Bırakılmamalıdır");
             else if (VoyageAddPlakacmb.SelectedIndex == -1)
                 MessageBox.Show("Plaka Seçilmelidir");
             else if (VoyageAddKaptancmb.SelectedIndex == -1)
                 MessageBox.Show("Kaptan Seçilmelidir");
             else if (VoyageAddYolcuKapasitesitxt.Text == "")
                 MessageBox.Show("Yolcu Kapasitesi Girilmelidir");
             else if (VoyageAddTarihtxt.Text == "")
                 MessageBox.Show("Tarih Boş Geçilmemelidir");
             else if (VoyageAddSaattxt.Text == "")
                 MessageBox.Show("Saat Boş Geçilmemelidir");
             else
             {
                if (MessageBox.Show("Seferi Eklemek İstediğinize Emin Misiniz ?", "Onay", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    string VoyageDatas = Convert.ToInt32(Globals.seferno) + "-" + VoyageAddTarihtxt.Text + "-" + VoyageAddSaattxt.Text + "-" + VoyageAddGuzergahcmb.Text + "-" + VoyageAddKaptancmb.Text + "-" +
                    VoyageAddPlakacmb.Text + "-" + VoyageAddYolcuKapasitesitxt.Text + "-" + VoyageAddBiletFiyatitxt.Text +"-"+ ";";
                    
                    VoyageDLList.AddNode(VoyageDatas);

                    //Koltuk listesi oluşturma
                    for (int i = 1; i <= Convert.ToInt32(VoyageAddYolcuKapasitesitxt.Text); i++)
                    {
                        SeatDLList.AddNode1(i.ToString()+"-"+VoyageAddBiletFiyatitxt.Text+"-"+" "+"-"+" "+"-"+"Boş"+"-");
                    }

                    VoyageDLList.Last.Otobus = SeatDLList.First;
                    //Girilen Sefer Bilgilerinin ve sefere ait olan koltuk bilgilerinin txt dosyasına yazılması 
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sws = File.CreateText(path))
                        {
                            sws.Close();
                        }
                    }
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        Node node = VoyageDLList.Last;
                        Node1 node1 = SeatDLList.First;
                        sw.Write(node.Data+Environment.NewLine);
                        while (node1 != null)
                        {
                            sw.Write(node1.Data+Environment.NewLine); 
                            node1 = node1.next;
                        }
                        sw.Close();
                       
                    }

                    //Girilen Sefer Bilgisilerinin ve koltuk bilgisinin tumseferlistesi txt dosyasına yazılması
                    if(!File.Exists(Globals.tumseferyolu))
                    {
                        using (StreamWriter sw = File.CreateText(Globals.tumseferyolu))
                        {
                            sw.Close();
                        }
                    }

                    using (StreamWriter sw = File.AppendText(Globals.tumseferyolu))
                    {
                        Node node = VoyageDLList.Last;
                        //Node1 node1 = SeatDLList.First;
                        sw.Write(node.Data + Environment.NewLine);
                        /*while (node1 != null)
                        //{
                          //  sw.Write(node1.Data + Environment.NewLine);
                          //  node1 = node1.next;
                        }*/
                        sw.Close();
                    }

                    Globals.seferno++;
                    SeatDLList.Delete1();
                    MessageBox.Show("Başarıyla Eklendi");
                }
                
               

             }
            
        }

        
    }
}
