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
    public partial class PersonCard : ContentView
    {

        public PersonCard(Person person) 
        {
            Person = person;
            InitializeComponent();
        }

        public PersonCard()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty PersonProperty =
           BindableProperty.Create(nameof(Person), typeof(Person), typeof(PersonCard), null);

        public static readonly BindableProperty NameProperty = 
            BindableProperty.Create(nameof(Name), typeof(string), typeof(PersonCard), string.Empty);
        public static readonly BindableProperty AgeProperty =
            BindableProperty.Create(nameof(Age), typeof(string), typeof(PersonCard), string.Empty);


        public Person Person
        {
            get => (Person)GetValue(PersonProperty);
            set => SetValue(PersonProperty, value);
        }

        public string Name
        {
            get { return Person.Name; }
        }

        public string Age
        {
            get { return Person.Age.ToString(); }
        }

        async void OnTapped(object sender, EventArgs args)
        {
            Page page = new NavigationPage(new PersonFullView(Person));
            await Navigation.PushAsync(new NavigationPage(page));
            
        }
    }
}