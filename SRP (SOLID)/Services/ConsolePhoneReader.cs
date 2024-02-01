using SRP__SOLID_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP__SOLID_.Services
{
    internal class ConsolePhoneReader : IPhoneReader
    {
        public string?[] GetInputData()
        {
            Console.WriteLine("Введите модель:");
            string? model = Console.ReadLine();
            Console.WriteLine("Введите стоимость:");
            string? price = Console.ReadLine();
            return new string?[] { model, price };
        }
    }
}
