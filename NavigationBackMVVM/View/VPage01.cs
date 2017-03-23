using System;

using Xamarin.Forms;

namespace NavigationBackMVVM
{
    public class VPage01 : ContentPage
    {
        public VPage01()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

