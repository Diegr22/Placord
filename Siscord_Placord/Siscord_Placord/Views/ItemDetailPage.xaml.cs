using Siscord_Placord.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Siscord_Placord.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}