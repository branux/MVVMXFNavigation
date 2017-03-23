using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using Xamarin.Forms;

namespace NavigationBackMVVM
{
    public class VMBase : INotifyPropertyChanged
    { 
    
        
        public static INavigationService NavigationPg=DependencyService.Get<INavigationService>(DependencyFetchTarget.GlobalInstance);
        
          public VMBase()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
