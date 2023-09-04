﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SignlRChat.Areas.Identity.Data;

// Add profile data for application users by adding properties to the SignlRChatUser class
public class SignlRChatUser : IdentityUser
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string place { get; set;}

    [Required]
    public string ProfileImage { get; set; }
    public object Description { get; internal set; }
}

