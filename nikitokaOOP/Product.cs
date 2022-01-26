using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace nikitokaOOP
{
    [DataContract]
    class Product
    {
        [DataMember]
        private string _name;
        [DataMember]
        private string _type;
        [DataMember]
        private List<Material> _materials = new List<Material>();
        [DataMember]
        private double _weight;
        [DataMember]
        private int _price;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public Material GetMaterial(int Index)
        {
            return _materials[Index];
        }
        public void AddMaterial(string Name, int PricePerGram)
        {
            _materials.Add(new Material(Name, PricePerGram));
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public Product(string Name, string Type, List<Material> Materials, double Weight, int Price )
        {
            _name = Name;
            _type = Type;
            _materials = Materials;
            _weight = Weight;
            _price = Price;
        }
    }
}
