﻿using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webservice;
using Xamarin.Forms;
using database.Entities;

namespace DiscountLocator19
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MyWebServiceCaller myWebServiceCaller = new MyWebServiceCaller();
        List<Store> stores;
        List<Discount> discounts;
        public MainPage()
        {
            InitializeComponent();
            FillList();
    }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
            await CallApi();
        }

        async Task CallApi()
        {
            var request =
            new Dictionary<String, String>();
            request.Add("method", "getAll");
           
            myWebServiceCaller.getAll(request, "store");
            myWebServiceCaller.getAll(request, "discount");

        }

        async void FillList()
        {
            stores = database.Database.DatabasePath.GetStores().Result;
            Storeslist.ItemsSource = stores;
            
        }

        
    }
}
