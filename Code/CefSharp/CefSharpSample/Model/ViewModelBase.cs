using System.ComponentModel;

namespace CefSharpSample.Model
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void SetStringProperty(string propertyName, ref string backingField, string value)
        {
            backingField = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
