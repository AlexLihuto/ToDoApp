using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp 
{
    class ToDoModel : INotifyPropertyChanged
{
        private string _ToDo;
        private bool _IsDone;

        public DateTime DateTime { get; set; } = DateTime.Now;

        public bool IsDone
        {
            get { return _IsDone; }
            set 
            {
                if (_IsDone == value)
                    return;
                _IsDone = value;
                OnPropertyChanged("IsDone");
            }
        }

        public string ToDo
        {
            get { return _ToDo; }
            set 
            {
                if (_ToDo == value)
                    return;
                _ToDo = value;
                OnPropertyChanged("ToDo");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
