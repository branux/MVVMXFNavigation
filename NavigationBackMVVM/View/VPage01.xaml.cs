using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationBackMVVM
{
    public partial class VPage01 : ContentPage
    {
        public VPage01()
        {
            BindingContext = new VMNavigation01();
            InitializeComponent();
        }
    }
}
