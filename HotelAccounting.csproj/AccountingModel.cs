using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAccounting
{
    //создайте класс AccountingModel здесь
    // В файле AccountingModel.cs создайте класс AccountingModel, унаследованный от ModelBase, со следующими свойствами.
    // double Price — цена за одну ночь.Должна быть неотрицательной.
    // int NightsCount — количество ночей. Должно быть положительным.
    // double Discount — скидка в процентах.Никаких дополнительных ограничений.
    // double Total — сумма счёта. Должна быть не отрицательна и должна быть согласована с предыдущими тремя свойствами по правилу: Total == Price* NightsCount * (1-Discount/100).
    // Все поля должны иметь сеттеры.При установке Price, NightsCount и Discount должна соответствующим образом устанавливаться Total, при установке Total — соответствующим образом меняться Discount.В случае установки значения, нарушающего хоть одно условие целостности, необходимо выкидывать ArgumentException.
    // При изменении значения любого свойства необходимо дополнительно сигнализировать об этом с помощью вызова метода Notify, передавая ему имя изменяемого свойства.Здесь можно воспользоваться ключевым словом nameof.

    class AccountingModel : ModelBase
    {
        private double price;
        private int nightsCount;
        private double discount;
        private double total;

        public double Price
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                price = value;
                Notify(nameof(Price));
                Notify(nameof(Total));
            }
            get { return price; }
        }

        public int NightsCount
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                nightsCount = value;
                Notify(nameof(NightsCount));
                Notify(nameof(Total));
            }
            get { return nightsCount; }
        }

        public double Discount
        {
            get { return discount; }
            set
            {
                if (value > 100)
                    throw new ArgumentException();
                discount = value;
                total = price * nightsCount * (1 - (discount / 100));
                Notify(nameof(Discount));
                Notify(nameof(Total));
            }
        }

        public double Total
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                total = value;
                discount = 100 * (1 - total / (price * nightsCount));
                Notify(nameof(Total));
                Notify(nameof(Discount));
            }
            get
            {
                return price * nightsCount * (1 - (discount / 100));
            }
        }
    }
}
