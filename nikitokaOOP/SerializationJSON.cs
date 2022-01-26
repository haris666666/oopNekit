using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace nikitokaOOP
{
    class SerializationJSON
    {
        DataContractJsonSerializer JSONSales = new DataContractJsonSerializer(typeof(Workshop));

        public Workshop SaveJSON(Workshop sales)
        {
            using (FileStream fs = new FileStream("Sales.json", FileMode.OpenOrCreate))
            {
                JSONSales.WriteObject(fs, sales);
            }
            return sales;
        }
        public Workshop LoadJSON(Workshop sales)
        {
            using (FileStream fs = new FileStream("Sales.json", FileMode.OpenOrCreate))
            {
                Workshop _sl = (Workshop)JSONSales.ReadObject(fs);
                sales = _sl;
                return sales;
            }
        }
    }
}

