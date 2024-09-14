using LittleUserManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleUserManager.Models
{
    public class UserManager
    {
        public static ObservableCollection<UserViewModel> dataBaseUsers = new ObservableCollection<UserViewModel>();

        public static ObservableCollection<UserViewModel> GetAllUsers() => dataBaseUsers;
        public static void AddUser(UserViewModel user) => dataBaseUsers.Add(user);
        public static void RemoveUser(UserViewModel user) => dataBaseUsers.Remove(user);
    }
}
