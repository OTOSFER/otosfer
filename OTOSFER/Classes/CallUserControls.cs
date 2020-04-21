using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace OTOSFER.Classes
{
    public class CallUserControls
    {
        public static void Add_Uc(Grid grd,UserControl uc)
        {
            
            if(grd.Children.Count>0)
            {
                grd.Children.Clear();
                grd.Children.Add(uc);
            }
            else { grd.Children.Add(uc); }

        }
    }

}
