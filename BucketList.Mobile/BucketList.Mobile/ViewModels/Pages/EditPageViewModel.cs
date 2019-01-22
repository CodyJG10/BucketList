﻿using BucketList.Api.Managers;
using BucketList.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BucketList.Mobile.ViewModels.Pages
{
    public class EditPageViewModel
    {
        public BucketListItem Item { get; set; }

        public ICommand SaveCommand { get; set; }

        public EditPageViewModel(BucketListItem item)
        {
            Item = item;
            SaveCommand = new Command(Save);
        }

        public void Save()
        {
            ProfileManager.Instance.SaveUser(App.User);
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}