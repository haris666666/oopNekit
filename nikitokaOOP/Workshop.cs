using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace nikitokaOOP
{
    [DataContract]
    class Workshop
    {
        [DataMember]
        private List<Sales> _sales = new List<Sales>();

        public Sales GetSales(int Index)
        {
            return _sales[Index];
        }

        public void AddSale()
        {
            List<Material> _material = new List<Material>();
            Console.WriteLine("Введите кол-во материалов в изделии: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите стоимость за грамм и имя " + i + " материала: ");
                string name = Console.ReadLine();
                int pricePerGram = Convert.ToInt32(Console.ReadLine());
                _material.Add(new Material(name, pricePerGram));
            }
            Console.WriteLine("Введите имя, тип, вес, стоимость: ");

            string namePr = Console.ReadLine();
            string typePr = Console.ReadLine();
            double weightPr = Convert.ToDouble(Console.ReadLine());
            int pricePr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите имя: ");
            string fullName = Console.ReadLine();

            _sales.Add(new Sales(fullName));

            Console.WriteLine("Введите индекс продажи: "); // индекс должен быть не более чем кол-во (сейлов - 1) иначе краш
            int index = Convert.ToInt32(Console.ReadLine());
            _sales[index].AddProduct(namePr, typePr, _material, weightPr, pricePr);
        }
    }
}
