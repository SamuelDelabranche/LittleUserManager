using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LittleUserManager.ViewModels
{
    public class AddUserViewModel : Observable
    {

        public ICommand ValidCommand { get; set; }

        public AddUserViewModel()
        {
            ValidCommand = new RelayCommand(AddUserCommand);
        }

        private void AddUserCommand(object obj)
        {
            var thisWindow = obj as Window;
            thisWindow.Close();
        }
    }
}
