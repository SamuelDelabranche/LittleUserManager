using LittleUserManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleUserManager.ViewModels
{
    public class MainWindowViewModel : Observable
    {
        public ObservableCollection<UserViewModel> Users { get; set; }

        public MainWindowViewModel()
        {
            Users = new ObservableCollection<UserViewModel>();
            Users.Add(new UserViewModel(new User("Samuel", "samuel.delabranche0@gmail.com", new DateTime(2004,12,04))));
        }
    }
}
