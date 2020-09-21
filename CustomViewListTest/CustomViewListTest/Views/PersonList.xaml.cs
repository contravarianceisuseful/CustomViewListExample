using CustomViewListTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomViewListTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonList : ContentPage
    {
        public PersonList()
        {
            InitializeComponent();
        }

        public List<Person> People;

        public List<PersonCard> cards { get; set; }
        public PersonList(List<Person> people)
        {
            InitializeComponent();
            People = people;
            cards = new List<PersonCard>();

            foreach (var p in people)
            {
                personStack.Children.Add(new PersonCard(p));
            }

            BindingContext = this;
        }


    }
}