using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingUI.Data
{
    public static class Data
    {
        public static ObservableCollection<Items> datas = new ObservableCollection<Items>
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
    }
}
