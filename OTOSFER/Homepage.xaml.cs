using OTOSFER.Classes;
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

namespace OTOSFER
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime tarih = DateTime.Today;
            Globals.gununtarihi = tarih.ToShortDateString();
        }
        private void Voyagebtn_Click_1(object sender, RoutedEventArgs e)
        {
            VoyageHomePage vhp = new VoyageHomePage();
			
            vhp.Show();
			
            this.Close();
        }

        private void Ticketbtn_Click(object sender, RoutedEventArgs e)
        {
            TicketHomePage thp = new TicketHomePage();
            thp.Show();
            this.Close();
        }

        
    }
}

