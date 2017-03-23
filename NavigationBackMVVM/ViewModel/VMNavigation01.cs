using System;
using Xamarin.Forms;
namespace NavigationBackMVVM
{
    public class VMNavigation01 : VMBase
    {
        public Command NavigationPage02Command { get; set; }
        public VMNavigation01()
        {
            NavigationPage02Command = new Command(async () => { await NavigationPg.PushPagina02(); });
        }
    }
}
