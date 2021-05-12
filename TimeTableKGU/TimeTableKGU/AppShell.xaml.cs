using System;
using System.Collections.Generic;
using TimeTableKGU.ViewModels;
using TimeTableKGU.Views;
using Xamarin.Forms;

namespace TimeTableKGU
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
