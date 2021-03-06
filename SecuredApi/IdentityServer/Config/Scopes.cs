using System.Collections.Generic;
using IdentityServer3.Core.Models;

namespace IdentityServer.Config
{
    public static class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            var scopes = new List<Scope>
            {
                StandardScopes.OpenId,
                StandardScopes.Profile,
                StandardScopes.Email,

                new Scope
                {
                    Enabled = true,
                    Name = "roles",
                    DisplayName = "Roles",
                    Description = "The user's roles.",
                    Type = ScopeType.Identity,
                    Claims = new List<ScopeClaim>
                    {
                        new ScopeClaim("role")
                    }
                },

                new Scope
                {
                    Name = "securedapi",
                    DisplayName = "Secured API Scope",
                    Type = ScopeType.Resource,
                    Emphasize = false,
                    Enabled = true,

                    Claims = new List<ScopeClaim>
                    {
                        new ScopeClaim("role")
                    }

                },

                new Scope
                {
                    Name = "api1",
                    DisplayName = "api1 scope",
                    Description = "This claim isn't used anywhere in this solution, it is meant for another test project.",
                    Type = ScopeType.Resource,
                    Emphasize = false,
                    Enabled = true
                }                
            };

            return scopes;
        }
    }
}
