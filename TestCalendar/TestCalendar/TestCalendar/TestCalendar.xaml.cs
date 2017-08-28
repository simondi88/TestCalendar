﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestCalendar
{
    public partial class TestCalendar : ContentPage
    {
        public TestCalendar()
        {
            InitializeComponent();
        }

        private async void SayHelloButton_OnClicked(object sender, EventArgs e)
        {
            var name = NameEntry.Text;
            await DisplayAlert("Greeting", $"Hello {name}!", "Howdy");
        }
    }
}
