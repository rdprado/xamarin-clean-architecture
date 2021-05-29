﻿using OrdersStore.Entities;
using OrdersStore.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrdersStore.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Order Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}