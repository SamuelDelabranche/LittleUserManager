using LittleUserManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LittleUserManager.ViewModels
{
    public class AddUserViewModel : Observable
    {
        public ICommand ValidCommand { get; set; }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
                (ValidCommand as RelayCommand)?.OnCanExecutedChanged();
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
                (ValidCommand as RelayCommand)?.OnCanExecutedChanged();
            }
        }

        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get
            {
                return _birthDate = DateTime.Now;
            }
            set
            {
                _birthDate = value;
                OnPropertyChanged(nameof(BirthDate));
            }
        }

        public AddUserViewModel()
        {
            ValidCommand = new RelayCommand(AddUserCommand, canAddUser);
        
        }

        private void AddUserCommand(object obj)
        {
            UserManager.AddUser(new UserViewModel(new User(_name, _email, _birthDate)));

            var thisWindow = obj as Window;
            thisWindow.Close();
        }

        private bool canAddUser(object obj)
        {
            return !(string.IsNullOrEmpty(_name) && string.IsNullOrEmpty(_email)) && 
                Regex.IsMatch(_email, @"^[a-zA-Z0-9._%+-]+@gmail\.com$", RegexOptions.IgnoreCase);
        }
    }
}
