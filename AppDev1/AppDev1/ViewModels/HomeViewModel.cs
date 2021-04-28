using AppDev1.Models;
using AppDev1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;
using AppDev1.Services;
using MvvmHelpers;
using MvvmHelpers.Commands;

namespace AppDev1.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<HomeModel> Lists { get; set; }

        public HomeViewModel()
        {
            Title = "Home";
            Lists = new ObservableCollection<HomeModel>();

            Lists.Add(new HomeModel { Id = 1, ListName = "Grocery" });
            Lists.Add(new HomeModel { Id = 2, ListName = "Stationary" });
            Lists.Add(new HomeModel { Id = 3, ListName = "Furnitures" });
            Lists.Add(new HomeModel { Id = 4, ListName = "School Supplies" });
        }


        //public ObservableRangeCollection<HomeModel> Lists { get; set; }
        //public AsyncCommand RefreshCommand { get; }

        //public AsyncCommand<HomeModel> RemoveCommand { get; }
        //public AsyncCommand<HomeModel> SelectedCommand { get; }

        ///// Adding list
        //string listName;
        //public string ListName { get => listName; set => SetProperty(ref listName, value); }

        //////// Save
        //public AsyncCommand SaveCommand { get; }

        //async Task Save()
        //{
        //    if (string.IsNullOrWhiteSpace(listName))
        //    {
        //        return;
        //    }

        //    await ListService.AddList(listName);

        //    await Shell.Current.GoToAsync("..");
        //}

        ///// </summary>
        //public HomeViewModel()
        //{

        //    Title = "Home Page";

        //    Lists = new ObservableRangeCollection<HomeModel>();


        //    RefreshCommand = new AsyncCommand(Refresh);
        //    RemoveCommand = new AsyncCommand<HomeModel>(Remove);
        //    SelectedCommand = new AsyncCommand<HomeModel>(Selected);

        //    SaveCommand = new AsyncCommand(Save);
        //}
        

        //async Task Selected(HomeModel list)
        //{
        //    if (list == null)
        //        return;

        //    var route = $"{nameof(HomePage)}?CoffeeId={list.Id}";
        //    await Shell.Current.GoToAsync(route);
        //}

        //async Task Remove(HomeModel list)
        //{
        //    await ListService.RemoveList(list.Id);
        //    await Refresh();
        //}

        //async Task Refresh()
        //{
        //    IsBusy = true;

        //    await Task.Delay(2000);

        //    Lists.Clear();

        //    var lists = await ListService.GetList();

        //    Lists.AddRange(lists);

        //    IsBusy = false;
        //}

    }
}
