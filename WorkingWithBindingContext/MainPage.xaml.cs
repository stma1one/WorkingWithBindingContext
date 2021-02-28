using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorkingWithBindingContext
{
    public partial class MainPage : ContentPage
    {
        
        Label LblTxt;
        BindableExample b;
            public MainPage()
        {
            InitializeComponent();
            LblTxt = new Label();
            LblTxt.HorizontalOptions = LayoutOptions.CenterAndExpand;
            LblTxt.FontSize = 25;
            Title = $"Page num ({App.pageNum++})";


            b= new BindableExample { Index = 0 };
            BindingContext = b;
            LblTxt.SetBinding(Label.TextProperty, "Names");
            stck.Children.Add(LblTxt);
            
         
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            MainPage next = new MainPage();
            ((BindableExample)this.BindingContext).Index++;
            next.BindingContext = this.BindingContext;
            await Navigation.PushAsync(next);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            SecondPage p = new SecondPage();
            p.BindingContext = this.BindingContext;
            await this.Navigation.PushAsync(p);

        }
    }
}
