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
        public ICommand ShowAddUserButton { get; set; }

        private bool _isButtonVisible;
        public bool IsButtonVisible
        {
            get
            {
                return _isButtonVisible;
            }
            set
            {
                _isButtonVisible = value;
                OnPropertyChanged(nameof(IsButtonVisible));
            }
        }

        private UserViewModel _selectedItem;
        public UserViewModel SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
                IsButtonVisible = _selectedItem != null;
            }
        }

        public MainWindowViewModel()
        {
            Users = UserManager.GetAllUsers();
            UserManager.AddUser(new UserViewModel(new User("Samuel", "samuel.delabranche0@gmail.com", new DateTime(2004, 04, 12))));

            ShowAddUserButton = new RelayCommand(ShowAddUserWindow);
            IsButtonVisible = false;
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
