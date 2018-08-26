using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class IterateProperties
    {

        public void IterateThrougObjectProperties(object p)
        {
            foreach (var prop in p.GetType().GetProperties())
            {
                if (!prop.PropertyType.IsValueType && prop.PropertyType != typeof(string))
                    IterateThrougObjectProperties(prop.GetValue(p));

                Console.WriteLine($"PropertyName: {prop.Name}, PropertyType : {prop.PropertyType.Name}, PropertyValue : {prop.GetValue(p)}");
            }



        }

        public void IterateThrougObjectPropertiesPrintSave<T>(T obj)
        {
            string s = string.Empty;
            
            foreach (var prop in obj.GetType().GetProperties())
            {
                if (prop.PropertyType.IsValueType || prop.PropertyType == typeof(string))
                    s+=$"*{prop.Name}* = *{prop.GetValue(obj)}*\n";
            }
            //s += $"Time {DateTime.Now}";
            File.WriteAllText("C:\\Temp\\file.txt", s);
            Console.WriteLine(s);

        }

    }
    public class BankCardInfo
    {
        //[SecureData]
        public string Cvv { get; set; }
        //[SecureData]
        public string Pin { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
    }

    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public BankCardInfo CardInfo { get; set; }

        //[SecureData]
        public string Passowrd { get; set; }
    }




}



