using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using Microsoft.Extensions.FileSystemGlobbing.Internal;

namespace Marvin.IDP;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new[]
        { 
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResource("roles",
                "Your role(s)",
                new [] {"role"}),
            new IdentityResource("country",
                "The country you're living in",
                new List<string>() { "country"} )
        };

    public static IEnumerable<ApiResource> ApiResource =>
        new[]
        {
            new ApiResource(
                "imagegalleryapi",
                "Image Gallery API",
                new [] { "role", "country" })
            {
                Scopes =
                {
                    "imagegalleryapi.fullaccess",
                    "imagegalleryapi.read",
                    "imagegalleryapi.write"
                },
                ApiSecrets = { new Secret("apisecret".Sha256())}
            }
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
            new ApiScope("imagegalleryapi.fullaccess"),
            new ApiScope("imagegalleryapi.read"),
            new ApiScope("imagegalleryapi.write")
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
            // new()
            // {
            //     ClientName = "Image Gallery",
            //     ClientId = "imagegalleryclientid",
            //     AllowedGrantTypes = GrantTypes.Code,
            //     AccessTokenType = AccessTokenType.Reference,
            //     //IdentityTokenLifetime = 5 min by default
            //     //AuthorizationCodeLifetime = 5 min by default
            //     AllowOfflineAccess = true,
            //     AccessTokenLifetime = 120,
            //     UpdateAccessTokenClaimsOnRefresh = true,
            //     RedirectUris =
            //     {
            //         "https://localhost:7184/signin-oidc"
            //     },
            //     PostLogoutRedirectUris =
            //     {
            //         "https://localhost:7184/signout-callback-oidc"
            //     },
            //     AllowedScopes =
            //     {
            //         IdentityServerConstants.StandardScopes.OpenId,
            //         IdentityServerConstants.StandardScopes.Profile,
            //         "roles",
            //         //"imagegalleryapi.fullaccess",
            //         "imagegalleryapi.read",
            //         "imagegalleryapi.write",
            //         "country"
            //     },
            //     ClientSecrets =
            //     {
            //         new Secret("secret".Sha256())
            //     },
            //     //consent screen
            //     //RequireConsent = true
            // },
            new()
            {
                ClientName = "Angular-Client",
                ClientId = "angular-client",
                AllowedGrantTypes = GrantTypes.Code,
                AccessTokenType = AccessTokenType.Jwt,
                AllowOfflineAccess = true,
                UpdateAccessTokenClaimsOnRefresh = true,
                RedirectUris = new List<string>
                {
                    "http://localhost:4200/signin-callback",
                    "http://localhost:4200/assets/silent-callback.html" 
                },
                RequirePkce = true,
                AllowAccessTokensViaBrowser = true,
                AllowedScopes =
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    "imagegalleryapi.read",
                    "imagegalleryapi.write",
                },
                AllowedCorsOrigins = { "http://localhost:4200" },
                RequireClientSecret = false,
                PostLogoutRedirectUris = new List<string> { "http://localhost:4200/signout-callback" },
                RequireConsent = false,
                AccessTokenLifetime = 600,
            }
        };
}