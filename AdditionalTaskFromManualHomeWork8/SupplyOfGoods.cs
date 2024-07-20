using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTaskFromManualHomeWork8
{
    class SupplyOfGoods : Document
    {
		private int _id;
		private string _supplyType;
        private int _supplyAmount;
        private DateOnly _date;
        
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string SupplyType
		{
			get { return _supplyType; }
			set { _supplyType = value; }
		}
        public int SupplyAmount
        {
            get { return _supplyAmount; }
            set { _supplyAmount = value; }
        }
        public DateOnly Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public SupplyOfGoods()
        {
            Id = new Random().Next();
            SupplyType = "Table";
            SupplyAmount = 20;
            Date = new DateOnly(2024, 3, 22);
        }
        public SupplyOfGoods(int id, string supplyType, int supplyAmount, DateOnly date)
        {
            Id = id;
            SupplyType = supplyType;
            SupplyAmount = supplyAmount;
            Date = date;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Информация о контракте на поставку товаров: " +
                $"\nId документа: {Id}" +
                $"\nТип поставляемого товара: {SupplyType}" +
                $"\nКоличество поставляемого товара: {SupplyAmount}" +
                $"\nДата поставки: {Date}\n");
        }
    }
}
