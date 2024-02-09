using System;
using System.ComponentModel;

namespace ShoppingUI
{
    public class Items : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Price { get; set; }
        private string _quantity;
        public string Quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged(nameof(Quantity));
                }
            }
        }
        public string Picture  { get; set; }
        public string Name    { get; set; }
        public int Group   { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
