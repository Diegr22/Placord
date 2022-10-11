using Siscord_Placord.ViewModels;
using Siscord_Placord.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Siscord_Placord
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
