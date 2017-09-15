﻿using System.ComponentModel.DataAnnotations;

namespace Mosaico.NetCore.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}