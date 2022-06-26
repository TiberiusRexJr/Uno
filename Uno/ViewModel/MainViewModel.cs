using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string text;
        public string Text
        {
            get => text;
            set 
            {
                text = value;
                OnPropertyChanged(nameof(text));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)=>PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
