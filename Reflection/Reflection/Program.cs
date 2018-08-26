using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            IterateProperties ip = new IterateProperties();
            Person p = new Person()
            {
                Age = 21,
                CardInfo = new BankCardInfo(),
                Email = "some@some.com",
                FirstName = "Tim",
                LastName = "R",
                Passowrd = "password1"
            };
            ip.IterateThrougObjectProperties(p);
            ip.IterateThrougObjectPropertiesPrintSave(p);
            Console.ReadLine();

        }
    }
}
