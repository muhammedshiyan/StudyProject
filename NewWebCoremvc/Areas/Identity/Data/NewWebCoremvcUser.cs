using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NewWebCoremvc.Areas.Identity.Data;

// Add profile data for application users by adding properties to the NewWebCoremvcUser class
public class NewWebCoremvcUser : IdentityUser
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set;}
    public string Password { get; set;}


}



