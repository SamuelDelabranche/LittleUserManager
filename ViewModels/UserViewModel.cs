using LittleUserManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleUserManager.ViewModels
{
    public class UserViewModel
    {
        public string Name { get; }
        public string Email { get; }
        public string BirthDate { get; }

        public UserViewModel(User user)
        {
            Name = user.Name;
            Email = user.Email;
            BirthDate = user.BirthDate.ToString("D");
        }

    }
}
