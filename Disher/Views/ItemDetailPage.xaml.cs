﻿using System.ComponentModel;
using Xamarin.Forms;
using Disher.ViewModels;

namespace Disher.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}