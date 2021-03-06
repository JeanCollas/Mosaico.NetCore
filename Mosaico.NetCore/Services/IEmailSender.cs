﻿using System.Threading.Tasks;

namespace Mosaico.NetCore.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}