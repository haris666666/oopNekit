using System;

namespace nikitokaOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializationJSON sr = new SerializationJSON(); // объект сериализации
            Workshop wk = new Workshop(); // объект мастерской
            wk =  sr.LoadJSON(wk); //вставляем в объект мастерской записи с жисон файла
            Console.WriteLine(wk.GetSales(1).Product.Name); //смотрим. В скобках индекс продажи
            wk.AddSale(); // добавляем нью обджект
            sr.SaveJSON(wk); // сохраняем
        }
    }
}
// к тому же если выйти из программы другим путем помимо ее окончания с кодом сохранения не будет (просто добивать действие проги до конца каждый раз)