using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using static Xamarin.Essentials.Permissions;

namespace Lumememm
{
    public partial class MainPage : ContentPage
    {
        Frame f1, f2, f3, hat, nose;
        Button btn1, btn2, btn3, btnrnd;
        Stepper step;
        ImageSource img;

        public MainPage()
        {
            BackgroundImageSource = "snezinka.jpg";


            step = new Stepper
            {
                Minimum = 0,
                Maximum = 50,
                Increment = 5
            };
            hat = new Frame();
            hat.HeightRequest = 70;
            hat.WidthRequest = 50;
            hat.BackgroundColor = Color.Black;
            hat.CornerRadius = 0;
            hat.Padding = 0;
            hat.HorizontalOptions = LayoutOptions.Center;
            hat.VerticalOptions = LayoutOptions.EndAndExpand;
            hat.Margin = new Thickness(0, 0, 0, -30);

            nose = new Frame();
            nose.HeightRequest = 40;
            nose.WidthRequest = 10;
            nose.BackgroundColor = Color.Orange;
            nose.CornerRadius = 20;
            nose.Padding = 0;
            nose.HorizontalOptions = LayoutOptions.Center;
            nose.VerticalOptions = LayoutOptions.Center;
            nose.Margin = new Thickness(0, -60, 20, 15);
            nose.Rotation = 25;

            step.ValueChanged += Step_ValueChanged;



            f1 = new Frame();
            f1.HeightRequest = 20;
            f1.WidthRequest = 20;
            f1.BackgroundColor = Color.White;
            f1.CornerRadius = 90;
            f1.Padding = 30;
            f1.HorizontalOptions = LayoutOptions.Center;
            f1.Opacity = 1;

            f2 = new Frame();
            f2.HeightRequest = 20;
            f2.WidthRequest = 20;
            f2.BackgroundColor = Color.White;
            f2.CornerRadius = 90;
            f2.Padding = 30;
            f2.HorizontalOptions = LayoutOptions.Center;
            f2.Opacity = 1;

            f3 = new Frame();
            f3.HeightRequest = 20;
            f3.WidthRequest = 20;
            f3.BackgroundColor = Color.White;
            f3.CornerRadius = 90;
            f3.Padding = 30;
            f3.HorizontalOptions = LayoutOptions.Center;
            f3.Opacity = 1;


            btn1 = new Button();
            btn1.Text = "hide snowman";
            btn1.BackgroundColor = Color.Lavender;
            btn1.HeightRequest = 50;
            btn1.WidthRequest = 50;

            btn2 = new Button();
            btn2.Text = "show snowman";
            btn2.BackgroundColor = Color.Lavender;
            btn2.HeightRequest = 50;
            btn2.WidthRequest = 50;

            btn3 = new Button();
            btn3.Text = "melt snowman";
            btn3.BackgroundColor = Color.Lavender;
            btn3.HeightRequest = 50;
            btn3.WidthRequest = 50;

            btnrnd = new Button();
            btnrnd.Text = "random color snowman";
            btnrnd.BackgroundColor = Color.Lavender;
            btnrnd.HeightRequest = 50;
            btnrnd.WidthRequest = 50;

            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btnrnd.Clicked += Btnrnd_Clicked;

            Content = new StackLayout { Children = { hat, f1, nose, f2, f3, btn1, btn2, btn3, btnrnd, step, } };
        }

        private void Tap2_Tapped(object sender, EventArgs e)
        {

            var imgsender = (Image)sender;
        }

        private void Step_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            f1.Padding = step.Value;
            f2.Padding = step.Value;
            f3.Padding = step.Value;




        }

        private void Btnrnd_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);

            Color randomColor = Color.FromRgb(r, g, b);
            f1.BackgroundColor = randomColor;
            f2.BackgroundColor = randomColor;
            f3.BackgroundColor = randomColor;
        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            f1.Opacity = 0.75;
            f2.Opacity = 0.75;
            f3.Opacity = 0.75;

            await Task.Run(() => Thread.Sleep(800));
            f1.Opacity = 0.50;
            f2.Opacity = 0.50;
            f3.Opacity = 0.50;

            await Task.Run(() => Thread.Sleep(800));
            f1.Opacity = 0.25;
            f2.Opacity = 0.25;
            f3.Opacity = 0.25;

            await Task.Run(() => Thread.Sleep(800));
            f1.Opacity = 0;
            f2.Opacity = 0;
            f3.Opacity = 0;

            await Task.Run(() => Thread.Sleep(800));
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            f1.Opacity = 1;
            f2.Opacity = 1;
            f3.Opacity = 1;
            hat.Opacity = 1;
            nose.Opacity = 1;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            f1.Opacity = 0;
            f2.Opacity = 0;
            f3.Opacity = 0;
            hat.Opacity = 0;
            nose.Opacity = 0;
        }

    }
}
