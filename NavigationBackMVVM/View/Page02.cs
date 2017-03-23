using System;

using Xamarin.Forms;

namespace NavigationBackMVVM
{
    public class Page02 : ContentPage
    {
        public Page02()
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

