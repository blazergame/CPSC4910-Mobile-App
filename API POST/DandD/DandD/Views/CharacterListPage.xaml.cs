﻿using DandD.Models.Game_Files;
using DandD.Models.GameFiles;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DandD.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterListPage : ContentPage
    {

        public CharacterListPage()
        {
            this.Title = "Character List";
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            CharacterListView.ItemsSource = await App.Database.RetrieveCharacters();
        }

        async void Character_CharacterSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new CharacterDetail { BindingContext = e.SelectedItem as Character });
            }
        }

    }


}
