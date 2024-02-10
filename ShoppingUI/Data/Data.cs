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
                //group 2
                ,
                new Items
                {
                    Id = 11,
                    Picture="xiaomi12tpro.jpg",
                    Name = "گوشی موبایل شیائومی مدل 12T Pro دو سیم کارت",
                    Quantity = "0",
                    Price = "317,990,000 ریال",
                    Group = 2,
                    Desc = "گوشی خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 12,
                    Picture="xiaomi13tpro.jpg",
                    Name = "گوشی موبایل شیائومی مدل 13T Pro",
                    Quantity = "0",
                    Price = "286,000,000 ریال",
                    Group = 2,
                    Desc = "گوشی خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 13,
                    Picture="xiaominote12pro.jpg",
                    Name = " شیائومی Redmi Note 12 Pro Plus 5G",
                    Quantity = "0",
                    Price = "179,000,000 ریال",
                    Group = 2,
                    Desc = "گوشی خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 14,
                    Picture="iphone13ch.jpg",
                    Name = "گوشی موبایل اپل مدل iPhone 13 CH",
                    Quantity = "0",
                    Price = "471,000,000 ریال",
                    Group = 2,
                    Desc = "گوشی خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 15,
                    Picture="iphone11.jpg",
                    Name = "گوشی موبایل اپل مدل iPhone 11",
                    Quantity = "0",
                    Price = "299,000,000 ریال",
                    Group = 2,
                    Desc = "گوشی خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 16,
                    Picture="iphone14promax.jpg",
                    Name = "گوشی موبایل اپل مدل iphone 14 Pro Max",
                    Quantity = "0",
                    Price = "786,000,000 ریال",
                    Group = 2,
                    Desc = "گوشی خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 17,
                    Picture="samsungs24ultra.jpg",
                    Name = " سامسونگ مدل Galaxy S24 Ultra",
                    Quantity = "0",
                    Price = "815,000,000 ریال",
                    Group = 2,
                    Desc = "گوشی خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 18,
                    Picture="samsungfold5.jpg",
                    Name = "موبایل سامسونگ مدل Galaxy Z Fold5",
                    Quantity = "0",
                    Price = "722,000,000 ریال",
                    Group = 2,
                    Desc = "گوشی خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 19,
                    Picture="samsungs23fe.jpg",
                    Name = "موبایل سامسونگ مدل Galaxy S23 FE ",
                    Quantity = "0",
                    Price = "228,000,000 ریال",
                    Group = 2,
                    Desc = "گوشی خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                },
                new Items
                {
                    Id = 20,
                    Picture="samsungzflip5.jpg",
                    Name = "موبایل سامسونگ مدل Galaxy Z Flip5",
                    Quantity = "0",
                    Price = "449,000,000 ریال",
                    Group=2,
                    Desc = "گوشی خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                }
                //group 4
                ,
                new Items
                {
                    Id = 21,
                    Picture="panasonic65.jpg",
                    Name = "پاناسونیک مدل 65lx700 سایز 65 اینچ",
                    Quantity = "0",
                    Price = "370,000,000 ریال",
                    Group=4,
                    Desc = "تلویزیون خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                }
                                ,
                new Items
                {
                    Id = 22,
                    Picture="tcl55tv.jpg",
                    Name = "تی سی ال مدل 55P635 سایز 55 اینچ",
                    Quantity = "0",
                    Price = "213,000,000 ریال",
                    Group=4,
                    Desc = "تلویزیون خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                }
                                ,
                new Items
                {
                    Id = 23,
                    Picture="deawoo56tv.jpg",
                    Name = "دوو مدل DSL-50SU1500 سایز 50 اینچ",
                    Quantity = "0",
                    Price = "181,000,000 ریال",
                    Group=4,
                    Desc = "تلویزیون خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                }
                                ,
                new Items
                {
                    Id = 24,
                    Picture="gplus55tv.jpg",
                    Name = "جی پلاس مدل GTV-65RQ752S سایز 65 اینچ",
                    Quantity = "0",
                    Price = "380,000,000 ریال",
                    Group=4,
                    Desc = "تلویزیون خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                }
                                ,
                new Items
                {
                    Id = 25,
                    Picture="gplus65tv.jpg",
                    Name = "جی پلاس مدل GTV-65PU750CN سایز 65 اینچ",
                    Quantity = "0",
                    Price = "345,000,000 ریال",
                    Group=4,
                    Desc = "تلویزیون خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                }
                                ,
                new Items
                {
                    Id = 26,
                    Picture="snowa55tv.jpg",
                    Name = " اسنوا مدل SSD-55SK610UG سایز 55 اینچ",
                    Quantity = "0",
                    Price = "200,000,000 ریال",
                    Group=4,
                    Desc = "تلویزیون خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                }
                                ,
                new Items
                {
                    Id = 27,
                    Picture="nexar40tv.jpg",
                    Name = " نکسار مدل NTV-H40B214N سایز 40 اینچ",
                    Quantity = "0",
                    Price = "79,000,000 ریال",
                    Group=4,
                    Desc = "تلویزیون خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                }
                                ,
                new Items
                {
                    Id = 28,
                    Picture="gplus58tv.jpg",
                    Name = "جی پلاس مدل GTV-58RU732N سایز 58 اینچ",
                    Quantity = "0",
                    Price = "235,000,000 ریال",
                    Group=4,
                    Desc = "تلویزیون خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                }
                                ,
                new Items
                {
                    Id = 29,
                    Picture="deawoo55tv.jpg",
                    Name = "دوو مدل DSL-55SU1730 سایز 55 اینچ",
                    Quantity = "0",
                    Price = "224,000,000 ریال",
                    Group=4,
                    Desc = "تلویزیون خیلی خوبی است !!! ، حتما پیشنهاد میکنم بخرید"
                }

            };
    }
}
