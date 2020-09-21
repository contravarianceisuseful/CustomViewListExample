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
    public partial class PersonFullView : ContentPage
    {
        public PersonFullView()
        {
            InitializeComponent();
   
        }

        public Person Person;

        public PersonFullView(Person person)
        {
            Person = person;
            InitializeComponent();
            PersonName.Text = person.Name;
            PersonAge.Text = person.Age.ToString();
        }


       public static readonly BindableProperty NameProperty =
          BindableProperty.Create(nameof(Name), typeof(string), typeof(PersonFullView), "No name");
       public static readonly BindableProperty AgeProperty =
           BindableProperty.Create(nameof(Age), typeof(string), typeof(PersonFullView), "No age");


        public string Name
        {
            get { return Person.Name; }
        }

        public string Age
        {
            get { return Person.Age.ToString(); }
        }
    }


}