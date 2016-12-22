using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentityServer.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Forename { get; set; }

        public string Lastname { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsWorker { get; set; }

        public bool IsAccepted { get; set; }
    }
}
