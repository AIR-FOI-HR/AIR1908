using Refit;
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
        public MainPage()
        {
            InitializeComponent();
    }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listViewDiscounts.ItemsSource = await database.Database.DatabasePath.GetDiscounts();
            listViewStores.ItemsSource = await database.Database.DatabasePath.GetStores();
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
        
        async void OnButtonClicked(object sender, EventArgs e)
        {
            Store[] storesItems = myWebServiceCaller.SendStoreItems();
            foreach (Store item in storesItems)
            {
                await database.Database.DatabasePath.InsertStores(new Store
                {
                    Name = item.Name,
                    Description = item.Description
                });
            }
                listViewDiscounts.ItemsSource = await database.Database.DatabasePath.GetDiscounts();
                listViewStores.ItemsSource = await database.Database.DatabasePath.GetStores();            
        }
    }
}
