using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;

namespace MegaPay.Authentication
{
    public interface IAuthenticationService
    {
        Task EnsureAuthenticatedNavigationAsync();
    }

    public class AuthenticationService : IAuthenticationService
    {
        private readonly AuthenticationStateProvider authStateProvider;
        private readonly NavigationManager navManager;

        public AuthenticationService(AuthenticationStateProvider authStateProvider, NavigationManager navManager)
        {
            this.authStateProvider = authStateProvider;
            this.navManager = navManager;
        }

        private bool isAuthenticatedChecked = false;
        private bool isAuthenticated = false;

        public async Task EnsureAuthenticatedNavigationAsync()
        {
            var authState = await authStateProvider.GetAuthenticationStateAsync();

            if (!authState.User.Identity.IsAuthenticated)
            {
                navManager.NavigateTo("/login");
            }
        }
    }
}
