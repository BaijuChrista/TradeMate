using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SC.Service.Interface
{
    public interface IEmailServices
    {
        System.Threading.Tasks.Task SendEmailAsync(string email, string subject, string htmlMessage);
       
    }
}
