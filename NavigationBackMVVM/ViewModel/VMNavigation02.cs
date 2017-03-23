using System;
using Xamarin.Forms;
namespace NavigationBackMVVM
{
    public class VMNavigation02 : VMBase
    {
        public Command NavigationPage01Command { get; set;}
        public VMNavigation02()
        {
            NavigationPage01Command = new Command(async () => {
                await Application.Current.MainPage.DisplayAlert("Mensagem", "Voltar para a pagina 01","ok");
                await NavigationPg.GoBack(true);
             });
        }
    }
}
