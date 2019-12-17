using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webservice;
using Xamarin.Forms;

namespace DiscountLocator19
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
    }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listViewStores.ItemsSource = await App.Database.GetStores();
            listViewDiscounts.ItemsSource = await App.Database.GetDiscounts();
            await CallApi();
        }

        async Task CallApi()
        {
            var request =
            new Dictionary<String, String>();
            request.Add("method", "getAll");

            MyWebServiceCaller myWebServiceCaller = new MyWebServiceCaller();
            myWebServiceCaller.getAll(request, "store");
            myWebServiceCaller.getAll(request, "discount");

        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameStoreEntry.Text) && !string.IsNullOrWhiteSpace(descriptionStoreEntry.Text) && !string.IsNullOrWhiteSpace(nameDiscountEntry.Text) && !string.IsNullOrWhiteSpace(valueDiscountEntry.Text))
            {
                await App.Database.InsertStores(new database.Entities.Store
                {
                    Name = nameStoreEntry.Text,
                    Description = descriptionStoreEntry.Text
                });
                await App.Database.InsertDiscounts(new database.Entities.Discount
                {
                    DiscountName = nameDiscountEntry.Text,
                    discountValue = int.Parse(valueDiscountEntry.Text)

                });
                nameStoreEntry.Text = descriptionStoreEntry.Text = nameDiscountEntry.Text = valueDiscountEntry.Text = string.Empty;
                listViewDiscounts.ItemsSource = await App.Database.GetDiscounts();
                listViewStores.ItemsSource = await App.Database.GetStores();

            }
        }
    }
}
