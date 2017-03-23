using System;
using System.Threading.Tasks;

namespace NavigationBackMVVM
{

/// <summary>
/// Interface responsavel pela navegacao
/// </summary>
    public interface INavigationService
    {
   
        
        Task GoBack(bool animate);
        Task GoToHome();
        Task PushPagina01();
       Task PushPagina02();
   
    }
}
