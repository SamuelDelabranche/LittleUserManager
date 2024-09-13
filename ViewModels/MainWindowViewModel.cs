using LittleUserManager.Models;
using LittleUserManager.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LittleUserManager.ViewModels
{
    public class MainWindowViewModel : Observable
    {
        public ObservableCollection<UserViewModel> Users { get; set; }
        public ICommand ShowAddUserButton {  get; set; }

        public MainWindowViewModel()
        {
            Users = new ObservableCollection<UserViewModel>();
            Users.Add(new UserViewModel(new User("Samuel", "samuel.delabranche0@gmail.com", new DateTime(2004,12,04))));

            ShowAddUserButton = new RelayCommand(ShowAddUserWindow);
        }

        private void ShowAddUserWindow(object obj)
        {
            var mainWindow = obj as Window;

            AddUser addUserWin = new AddUser();
            addUserWin.Owner = mainWindow;   
            addUserWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addUserWin.Show();
        }
    }
}
