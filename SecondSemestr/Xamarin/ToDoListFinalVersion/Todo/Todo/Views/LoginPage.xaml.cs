using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Todo.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        async void OnSaveClicked(object sender, EventArgs e)
        {
           string login = Login.Text;
            //string login = ((Entry)sender).Text;
            if(login == "Oleg")
            {
                await Navigation.PushAsync(new TodoListPage
                {
                });
            }
        
        }
    }
}
