using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationBackMVVM
{
    public partial class VPage02 : ContentPage
    {
        public VPage02()
        {
         BindingContext = new VMNavigation02();
            InitializeComponent();
        }
    }
}
