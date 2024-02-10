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
                    Picture="m200motor.jpg",
                    Name = "موتور سیکلت پرواز مدل CDI 200",
                    Quantity = "0",
                    Price = "653,200,000 ریال",
                    Group = 3,
                    Desc = "موتور خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 2,
                    Picture="madv150motor.jpg",
                    Name = "موتور سیکلت طرح ADV150",
                    Quantity = "0",
                    Price = "1,376,600,000 ریال",
                    Group = 3,
                    Desc = "موتور خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 3,
                    Picture="maeroxmotor.jpg",
                    Name = "موتور سیکلت طرح آیرکس",
                    Quantity = "0",
                    Price = "918,860,000 ریال",
                    Group = 3,
                    Desc = "موتور خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 4,
                    Picture="matv300motor.jpg",
                    Name = "موتور چهار چرخ مدل کایو ATV300",
                    Quantity = "0",
                    Price = "5,000,000,000 ریال",
                    Group = 3,
                    Desc = "موتور خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 5,
                    Picture="mbd249motor.jpg",
                    Name = "موتور سیکلت دینو مدل بندا",
                    Quantity = "0",
                    Price = "3,547,000,000 ریال",
                    Group = 3,
                    Desc = "موتور خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 6,
                    Picture="mbenelymotor.jpg",
                    Name = "موتورسیکلت بنلی مدل panarea125",
                    Quantity = "0",
                    Price = "1,192,000,000 ریال",
                    Group = 3,
                    Desc = "موتور خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                }
                ,
                new Items
                {
                    Id = 7,
                    Picture="mbp500motor.jpg",
                    Name = "موتورسیکلت چهار چرخ مدل bp500",
                    Quantity = "0",
                    Price = "3,547,000,000 ریال",
                    Group = 3,
                    Desc = "موتور خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 8,
                    Picture="mclickmotor.jpg",
                    Name = "موتور سیکلت کلیک مدل i150",
                    Quantity = "0",
                    Price = "839,000,000 ریال",
                    Group = 3,
                    Desc = "موتور خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 9,
                    Picture="mgalaxymotor.jpg",
                    Name = "موتور سیکلت گلکسی مدل SF180",
                    Quantity = "0",
                    Price = "1,286,000,000 ریال",
                    Group = 3,
                    Desc = "موتور خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 10,
                    Picture="mna180motor.jpg",
                    Name = "موتور سیکلت گلکسی اس وای ام",
                    Quantity = "0",
                    Price = "3,547,000,000 ریال",
                    Group = 3,
                    Desc = "موتور خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                }
            };
    }
}
