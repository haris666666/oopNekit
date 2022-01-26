using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace nikitokaOOP
{
    [DataContract]
    class Sales
    {
        [DataMember]
        Product _product;
        [DataMember]
        private string _dateOfSale;
        [DataMember]
        private string _fullName;

        public string DateOfSale
        {
            get { return _dateOfSale; }
            set { _dateOfSale = value; }
        }
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        public Product Product
        {
            get { return _product; }
        }
        public void AddProduct(string Name, string Type, List<Material> Materials, double Weight, int Price)
        {
            _product = new Product(Name, Type, Materials, Weight, Price);
        }
        Sales()
        {
            _dateOfSale = Convert.ToString(DateTime.Now.ToShortDateString());
        }
        public Sales(string FullName)
        {
            _dateOfSale = Convert.ToString(DateTime.Now.ToShortDateString());
            _fullName = FullName;
        }


    }
}
