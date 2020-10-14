using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CircleImageDemo
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void RaisePropertyChanged<T>(ref T property, T value, [CallerMemberName] String propertyName = "")
        {
            if ((property == null && value != null) || (property != null && !property.Equals(value)))
            {
                property = value;
                RaisePropertyChanged(propertyName);
            }
        }
    }
}
