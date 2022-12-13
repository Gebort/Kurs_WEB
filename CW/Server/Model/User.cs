using CW.Shared.Model;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CW.Server.Model {
    public class User : IdentityUser {

        public List<Writing> Writings { get; set; } = new();

    }
}
