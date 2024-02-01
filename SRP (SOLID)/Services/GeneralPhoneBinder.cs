using SRP__SOLID_.Interfaces;
using SRP__SOLID_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP__SOLID_.Services
{
    internal class GeneralPhoneBinder : IPhoneBinder
    {
        public Phone CreatePhone(string?[] data)
        {
            if (data is { Length:2} && data[0] is string model &&
                model.Length > 0 && int.TryParse(data[1],out var price))
            {
                return new Phone(model,price);
            }
            else
            {
                throw new ArgumentException("Некоректные данные");
            }
        }
    }
}
