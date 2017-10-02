using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TruecaApp.Pages
{
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            App.Navigator = Navigator;
        }
    }
}
