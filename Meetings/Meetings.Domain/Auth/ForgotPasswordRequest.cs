﻿using System.ComponentModel.DataAnnotations;

namespace Meetings.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
