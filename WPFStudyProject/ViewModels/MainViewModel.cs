using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFStudyProject.Helpers;

namespace WPFStudyProject.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {

        private string _message = "Olá, mundo WPF com MVVM!";
        public string Message
        {
            get => _message;
            set { _message = value; OnPropertyChanged(); }
        }

        public ICommand ClickCommand { get; }

        public MainViewModel()
        {
            ClickCommand = new RelayCommand(() => Message = "Você clicou no botão!");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

    }
}
