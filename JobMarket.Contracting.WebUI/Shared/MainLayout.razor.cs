using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobMarket.Contracting.WebUI.Shared
{
    public class MainLayoutModel : LayoutComponentBase
    {
        [Inject] protected AppState _appState { get; set; }

        protected async Task Logout()
        {
            await _appState.Logout();
        }
        protected override async Task OnInitializedAsync()
        {
            await _appState.CheckState();
        }
    }

}
