using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
          //  GetUser();
        }
        private async void OnNextPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
        
        //private async void GetUser()
        //{
        //    HttpClient Client = new HttpClient();
        //    var response = await Client.GetStringAsync("https://jsonplaceholder.typicode.com/todos");
        //    var User=JsonConvert.DeserializeObject<List<Users>>(response);
        //    UsersListView.ItemsSource =User;
        //}
    }
}
