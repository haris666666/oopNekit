using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace nikitokaOOP
{
    [DataContract]
    class Material
    {
        [DataMember]
        private string _name;
        [DataMember]
        private int _pricePerGram;
        public Material(string Name, int PricePerGram)
        {
            _name = Name;
            _pricePerGram = PricePerGram;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int PricePerGram
        {
            get { return _pricePerGram; }
            set { _pricePerGram = value; }
        }
    }
}
