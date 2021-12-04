using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using System.Threading.Tasks;

namespace ReactionGame
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        public string GenerateRandomFruit()
        {
            string[] fruits = { "bananas.png", "dragon.png", "orange.png", "watermelon.png", "strawberry.png", "apple.png", "lemon.png" };
            int rnd = new Random().Next(0, 7);
            return fruits[rnd];
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            bannerImage.Source = GenerateRandomFruit();
            
        }

        private async void StartButton_Clicked(System.Object sender, System.EventArgs e)
        {
            startButton.IsVisible = false;
            bannerImage.IsVisible = false;
            counterLabel.IsVisible = true;

            var parentAnimation = new Animation();
            var scaleUp = new Animation(v => counterLabel.Scale = v, 1, 2, Easing.SpringIn);
            var scaleDown = new Animation(v => counterLabel.Scale = v, 2, 1, Easing.SpringOut);

            counterLabel.Text = "۳";
            counterLabel.TextColor = Color.FromHex("EF233C");
            counterLabel.FontSize = 100;
            counterLabel.FontAttributes = FontAttributes.Bold;

            parentAnimation.Add(0, 0.5, scaleUp);
            parentAnimation.Add(0.5, 1, scaleDown);
            parentAnimation.Commit(counterLabel, "counterAnim", 16, 1000, null);

            await Task.Delay(1000);

            counterLabel.Text = "۲";
            parentAnimation = new Animation();
            scaleUp = new Animation(v => counterLabel.Scale = v, 1, 2, Easing.SpringIn);
            scaleDown = new Animation(v => counterLabel.Scale = v, 2, 1, Easing.SpringOut);

            parentAnimation.Add(0, 0.5, scaleUp);
            parentAnimation.Add(0.5, 1, scaleDown);
            parentAnimation.Commit(counterLabel, "counterAnim", 16, 1000, null);

            await Task.Delay(1000);

            counterLabel.Text = "۱";
            parentAnimation = new Animation();
            scaleUp = new Animation(v => counterLabel.Scale = v, 1, 2, Easing.SpringIn);
            scaleDown = new Animation(v => counterLabel.Scale = v, 2, 1, Easing.SpringOut);

            parentAnimation.Add(0, 0.5, scaleUp);
            parentAnimation.Add(0.5, 1, scaleDown);
            parentAnimation.Commit(counterLabel, "counterAnim", 16, 1000, null);

            await Task.Delay(300);

            counterLabel.IsVisible = false;
            bannerImage.IsVisible = true;
            bannerImage.Source = GenerateRandomFruit();
            img1.Source = GenerateRandomFruit();
            img2.Source = GenerateRandomFruit();
            img3.Source = GenerateRandomFruit();
            img4.Source = GenerateRandomFruit();
            img5.Source = GenerateRandomFruit();
            img6.Source = GenerateRandomFruit();
            img7.Source = GenerateRandomFruit();
            img8.Source = GenerateRandomFruit();
            img9.Source = GenerateRandomFruit();
            img10.Source = GenerateRandomFruit();
            img11.Source = GenerateRandomFruit();
            img12.Source = GenerateRandomFruit();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }

}
