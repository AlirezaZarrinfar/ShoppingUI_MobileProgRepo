using Syncfusion.Maui.DataSource.Extensions;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ShoppingUI
{
    public class ProductPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string _totalAmount = "0$";
        public string TotalAmount
        {
            get { return _totalAmount; }
            set
            {
                if (_totalAmount != value)
                {
                    _totalAmount = value;
                    OnPropertyChanged();
                }
            }
        }
        private ObservableCollection<Items> _items;

        public ObservableCollection<Items> Items
        {
            get { return _items; }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        private ObservableCollection<Items> _allItems;

        public ObservableCollection<Items> AllItems
        {
            get { return _allItems; }
            set
            {
                if (_allItems != value)
                {
                    _allItems = value;
                    OnPropertyChanged(nameof(AllItems));
                }
            }
        }
        public ObservableCollection<Items> CartItems { get; set; }

        public Items SelectedItem { get; set; }

        public ICommand Itemclick { get; set; }
        public ICommand CartItemclick { get; set; }
        public ICommand AddItemclick { get; set; }
        public ICommand DeleteItemclick { get; set; }
        public ICommand GroupFilterclick { get; set; }
        public ProductPageViewModel(INavigation navigation)
        {
            AllItems = new ObservableCollection<Items>
            {
                new Items
                {
                    Id = 1,
                    Picture="watch.png",
                    Name = "Cool Watch",
                    Quantity = "0",
                    Price = "$99",
                    Group = 2
                },
                new Items
                {
                    Id = 2,
                    Picture="divingwatch.png",
                    Name = "Diving Watch",
                    Quantity = "0",
                    Price = "$89",
                    Group = 3
                },
                new Items
                {
                    Id = 3,
                    Picture="dresswatch.png",
                    Name = "Dress Watch",
                    Quantity = "0",
                    Price = "$85",
                    Group = 2
                },
                new Items
                {
                    Id = 4,
                    Picture="militarywatch.png",
                    Name = "Military Watch",
                    Quantity = "0",
                    Price = "$99",
                    Group = 3
                },
                new Items
                {
                    Id = 5,
                    Picture="wristwatch.png",
                    Name = "Wrist Watch",
                    Quantity = "0",
                    Price = "$85",
                    Group = 4
                },
                new Items
                {
                    Id = 6,
                    Picture="militarywatch.png",
                    Name = "Army Watch",
                    Quantity = "0",
                    Price = "$99",
                    Group = 3
                }
            };
            Items = AllItems;
            CartItems = new ObservableCollection<Items> { };
            Itemclick = new Command<Items>(executeitemclickcommand);
            CartItemclick = new Command<Items>(executeCartitemclickcommand);
            AddItemclick = new Command<Items>(executeAddItemcommand);
            DeleteItemclick = new Command<Items>(executeDeleteItemcommand);
            GroupFilterclick = new Command<string>(execgroupcommand);
            this.navigation = navigation;
        }
        private INavigation navigation;

        async void executeitemclickcommand(Items item)
        {
            this.SelectedItem = item;
            await navigation.PushModalAsync(new DetailsPage(this));
        }

        async void executeCartitemclickcommand(Items item)
        {
            SelectedItem.Quantity = (Convert.ToInt32(SelectedItem.Quantity) + 1).ToString();
            TotalAmount = "$" + (Convert.ToInt32(TotalAmount.Replace("$", "")) + Convert.ToInt32(SelectedItem.Price.Replace("$", ""))).ToString();

            if (CartItems?.FirstOrDefault(p => p.Id == SelectedItem.Id) == null)
            {
                this.CartItems.Add(this.SelectedItem);
            }
            await navigation.PushModalAsync(new CartPage(this));

        }

        void executeAddItemcommand(Items item)
        {
            item.Quantity = (Convert.ToInt32(item.Quantity) + 1).ToString();
            TotalAmount = "$" + (Convert.ToInt32(TotalAmount.Replace("$", "")) + Convert.ToInt32(item.Price.Replace("$", ""))).ToString();
        }

        void executeDeleteItemcommand(Items item)
        {
            item.Quantity = (Convert.ToInt32(item.Quantity) - 1).ToString();
            if (item.Quantity == "0")
                CartItems.Remove(item);
            TotalAmount = "$" + (Convert.ToInt32(TotalAmount.Replace("$", "")) - Convert.ToInt32(item.Price.Replace("$", ""))).ToString();
        }
        async void execgroupcommand(string group)
        {
            if (group == "1")
                Items = AllItems;
            else
                Items = AllItems.Where(p => p.Group == Convert.ToInt32(group)).ToObservableCollection();
            var page = new ProductPage();
            page.BindingContext = this;
            await navigation.PushModalAsync(page);
        }
    }
}
