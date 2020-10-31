// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.using System.Collections.Generic;

using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace IdentityServerHost.Configuration
{
    public static class ClientsWeb
    {
        static string[] allowedScopes =
        {
            IdentityServerConstants.StandardScopes.OpenId,
            IdentityServerConstants.StandardScopes.Profile,
            IdentityServerConstants.StandardScopes.Email,
            "resource1.scope1",
            "resource2.scope1",
            "transaction"
        };

        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                ///////////////////////////////////////////
                // Postman
                //////////////////////////////////////////
                new Client
                {
                    ClientId = "postman-api",
                    ClientName = "Postman Test Client",
                    AllowedGrantTypes = GrantTypes.Code,
                    AllowAccessTokensViaBrowser = true,
                    AllowOfflineAccess = true,
                    RequireConsent = false,
                    RequirePkce = false,
                    RedirectUris = { "https://www.getpostman.com/oauth2/callback"},
                    PostLogoutRedirectUris = { "https://www.getpostman.com"},
                    AllowedCorsOrigins = { "https://www.getpostman.com"},
                    EnableLocalLogin = true,
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.LocalApi.ScopeName
                    },
                    ClientSecrets = new List<Secret>() { new Secret("thenameofthegame".Sha256())}
                }
            };
        }
    }
}