using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeVille.SPA.UI.Core
{
    /// <summary>
    /// inheriting from IdentityDbContext 
    /// a special version of the traditionl DbContext class
    /// which provides all of the EF code-first mapping and 
    /// needed DbSet properties
    /// </summary>
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext() : base("AuthContext")
        {

        }

        public System.Data.Entity.DbSet<CodeVille.SPA.UI.Models.UserModel> UserModels { get; set; }
    }
}