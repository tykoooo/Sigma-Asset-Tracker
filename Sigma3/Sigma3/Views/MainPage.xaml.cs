﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Sigma3.Objects;

namespace Sigma3
{
    public partial class MainPage : TabbedPage
    {
        public static User USER_LOGGED_IN { get; set; }
        public static string PageTitle { get; set; } 
        public MainPage(User user)
        {
            USER_LOGGED_IN = user;
            InitializeComponent();
            BarBackgroundColor = Color.Black;
            BarTextColor = Color.Black;
            this.BindingContext = this;

        }

        public MainPage()
        {
            InitializeComponent();
            BarBackgroundColor = Color.Black;
            BarTextColor = Color.Black;
        }
    }
}
