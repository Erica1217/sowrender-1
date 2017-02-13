using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace YesOrNo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void EntryClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new ResponsePage());
        }
    }
}
