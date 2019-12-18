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
        List<Store> stores;
        List<Discount> discounts;
        public MainPage()
        {
            InitializeComponent();
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
        
        async void OnButtonClicked(object sender, EventArgs e)
        {
            await database.Database.DatabasePath.InsertStores(new Store
            {
                Name = nameStoreEntry.Text,
                Description = descriptionStoreEntry.Text
            });
            stores = database.Database.DatabasePath.GetStores().Result;
            discounts = database.Database.DatabasePath.GetDiscounts().Result;
            listViewDiscounts.ItemsSource = discounts;
            listViewStores.ItemsSource = stores;
        }
    }
}
