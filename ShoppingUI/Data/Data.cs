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
                    Picture="200.jpg",
                    Name = "موتور سیکلت پرواز مدل CDI 200",
                    Quantity = "0",
                    Price = "653,200,000 R",
                    Group = 3
                },
                new Items
                {
                    Id = 2,
                    Picture="Adv150.jpg",
                    Name = "موتور سیکلت طرح ADV150",
                    Quantity = "0",
                    Price = "1,376,600,000 R",
                    Group = 3
                },
                new Items
                {
                    Id = 3,
                    Picture="aerox.jpg",
                    Name = "موتور سیکلت طرح آیرکس",
                    Quantity = "0",
                    Price = "918,860,000 R",
                    Group = 3
                },
                new Items
                {
                    Id = 4,
                    Picture="atv300.jpg",
                    Name = "موتور چهار چرخ مدل کایو ATV300",
                    Quantity = "0",
                    Price = "5,000,000,000 R",
                    Group = 3
                },
                new Items
                {
                    Id = 5,
                    Picture="bd249.jpg",
                    Name = "موتور سیکلت دینو مدل بندا",
                    Quantity = "0",
                    Price = "3,547,000,000 R",
                    Group = 3
                },
                new Items
                {
                    Id = 6,
                    Picture="benely.jpg",
                    Name = "موتورسیکلت بنلی مدل panarea125 ",
                    Quantity = "0",
                    Price = "1,192,000,000 R",
                    Group = 3
                }
                ,
                new Items
                {
                    Id = 7,
                    Picture="bp500.jpg",
                    Name = "موتورسیکلت چهار چرخ مدل bp500",
                    Quantity = "0",
                    Price = "3,547,000,000 R",
                    Group = 3
                },
                new Items
                {
                    Id = 8,
                    Picture="click.jpg",
                    Name = "موتور سیکلت کلیک مدل i150 ",
                    Quantity = "0",
                    Price = "839,000,000 R",
                    Group = 3
                },
                new Items
                {
                    Id = 9,
                    Picture="galaxy.jpg",
                    Name = "موتور سیکلت گلکسی مدل SF180",
                    Quantity = "0",
                    Price = "1,286,000,000 R",
                    Group = 3
                },
                new Items
                {
                    Id = 10,
                    Picture="na180.jpg",
                    Name = "موتور سیکلت گلکسی اس وای ام",
                    Quantity = "0",
                    Price = "3,547,000,000 R",
                    Group = 3
                }
            };
    }
}
