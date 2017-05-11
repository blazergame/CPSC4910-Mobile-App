﻿using DandD.Helpers;
using DandD.Models.Game_Files;
using DandD.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DandD.ViewModels
{
    class BaseCharacterModel : ObservableObject
    {
        /// <summary>
        /// Get the azure service instance
        /// </summary>
        public IDataStore<Character> DataStore => DependencyService.Get<IDataStore<Character>>();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }
        /// <summary>
        /// Private backing field to hold the title
        /// </summary>
        string title = string.Empty;
        /// <summary>
        /// Public property to set and get the title of the item
        /// </summary>
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
    }
}
