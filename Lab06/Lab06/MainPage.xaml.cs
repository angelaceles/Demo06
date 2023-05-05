using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab06
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<string> colores = new List<string>();

            colores.Add("Red");
            colores.Add("Yellow");
            colores.Add("Blue");
            colores.Add("Green");
            colores.Add("While");

            lvColores.ItemsSource = colores;
        }
    }
}
