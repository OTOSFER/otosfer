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
using System.Windows.Shapes;
using OTOSFER.Classes;
using OTOSFER.UserControls;

namespace OTOSFER
{
    /// <summary>
    /// TicketHomePage.xaml etkileşim mantığı
    /// </summary>
    public partial class TicketHomePage : Window
    {
        public TicketHomePage()
        {
            InitializeComponent();
        }

        private void ticketsagust_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void TicketClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void availablevoyagelistbtn_Click(object sender, RoutedEventArgs e)
        {
            CallUserControls.Add_Uc(Ticketicerik,new AvailableVoyageListUc());
        }
    }
}
