using System.Collections.Generic;
using System.ComponentModel;

namespace BugInList
{
    public class ViewModel
    {
        public List<ViewModelItem> Items { get; } = new()
        {
            new ViewModelItem("First"),
            new ViewModelItem("Second"),
            new ViewModelItem("Third"),
        };
    }

    public class ViewModelItem : INotifyPropertyChanged
    {
        public ViewModelItem(string initialValue)
        {
            this.value = initialValue;
        }

        private string value;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Value
        {
            get => value;
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
                }
            }
        }

    }
}
