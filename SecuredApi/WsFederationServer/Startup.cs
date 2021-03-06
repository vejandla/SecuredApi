﻿using System;
using System.Security.Cryptography.X509Certificates;
using IdentityServer.WindowsAuthentication.Configuration;
using Owin;
using WsFederationServer.Services;

namespace WsFederationServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWindowsAuthenticationService(new WindowsAuthenticationOptions
            {
                IdpRealm = "urn:win",
                IdpReplyUrl = "https://secured.local:449/identityserver/core/was",
                PublicOrigin = "https://localhost:44300/",
                SigningCertificate = LoadCertificate(),
                CustomClaimsProvider = new AdditionalWindowsClaimsProvider()
            });
        }

        private X509Certificate2 LoadCertificate() => new X509Certificate2(
            $@"{AppDomain.CurrentDomain.BaseDirectory}\certificates\secured.local.pfx", "");
    }
}