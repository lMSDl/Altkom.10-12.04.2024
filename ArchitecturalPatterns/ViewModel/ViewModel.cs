using ArchitecturalPatterns.Commands;
using ArchitecturalPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ArchitecturalPatterns.ViewModel
{
    internal class ViewModel : NotifyPropertyChanged
    {
        private string inputValue;

        public SomeModel Model { get; set; }


        public string InputValue
        {
            get => inputValue;
            set
            {
                inputValue = value;
                OnPropertyChanged();
            }
        }


        public ViewModel()
        {
            Model = new SomeModel();
            SaveCommand = new Command(x => InputValue != Model.Value, x => { Model.Value = InputValue; });
            LoadCommand = new Command(x => InputValue != Model.Value, x => InputValue = Model.Value);
        }


        public Command SaveCommand { get; set; }
        public Command LoadCommand { get; set; }
    }
}
