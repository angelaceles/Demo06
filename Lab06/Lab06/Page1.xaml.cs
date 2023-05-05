using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void btnGetPeople_Clicked(object sender, EventArgs e)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { Name = "Hugo", LastName = "Torrico", DNI = "987354263" });
            people.Add(new Person { Name = "Pasco", LastName = "Lopez", DNI = "273646732" });
            people.Add(new Person { Name = "Luis", LastName = "Marquez", DNI = "987467324" });
            people.Add(new Person { Name = "Miguel", LastName = "Palomino", DNI = "476274748" });

            lvPeople.ItemsSource = people;
        }
    }
}