using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationBackMVVM
{
/// <summary>
/// Implementacao da Interface de Navegacao
/// </summary>
    public class NavigationService:INavigationService
    {
      /// <summary>
      /// Retorna para a Navegacao anterior
      /// </summary>
      /// <returns>The back.</returns>
      /// <param name="animate">If set to <c>true</c> animate.</param>
        public async Task GoBack(bool animate)
        {
            await Application.Current.MainPage.Navigation.PopAsync(animate);
        }
        /// <summary>
        /// Retorna para a Navegacao Inicial
        /// </summary>
        /// <returns>The to home.</returns>
        public async Task GoToHome()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new VPage01());
        }
/// <summary>
/// Vai para a pagina 01
/// </summary>
/// <returns>The pagina01.</returns>
        public async Task PushPagina01()
        {
             await Application.Current.MainPage.Navigation.PushAsync(new VPage01());
        }
            /// <summary>
            /// Vai para a pagina 02
            /// </summary>
            /// <returns>The pagina02.</returns>
        public async Task PushPagina02()
        {
             await Application.Current.MainPage.Navigation.PushAsync(new VPage02());
        }
    }
}
