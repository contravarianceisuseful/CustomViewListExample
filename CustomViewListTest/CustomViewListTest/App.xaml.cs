using CustomViewListTest.Models;
using CustomViewListTest.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomViewListTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            List<Person> peeps = new List<Person> { new Person("Test Guy1", 23), new Person("Test Guy21", 26) };

            MainPage = new NavigationPage(new PersonList(peeps));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
