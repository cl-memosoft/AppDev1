using AppDev1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppDev1.Views
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