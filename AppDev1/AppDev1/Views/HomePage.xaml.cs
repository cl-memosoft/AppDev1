using AppDev1.Models;
using AppDev1.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDev1.Views
{
    public partial class HomePage : ContentPage
    {
        HomeViewModel homeViewModel;
        public HomePage()
        {
            InitializeComponent();

            BindingContext = homeViewModel = new HomeViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void btnListPopup_Clicked(object sender, EventArgs e)
        {
            popUpAddListView.IsVisible = true;
            MyList.IsVisible = false;
        }

        private void btnCancelPopup_Clicked(object sender, EventArgs e)
        {
            popUpAddListView.IsVisible = false;
            MyList.IsVisible = true;
        }

    }
}