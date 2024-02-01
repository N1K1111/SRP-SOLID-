using SRP__SOLID_.Interfaces;
using SRP__SOLID_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP__SOLID_.Services
{
    internal class GeneralPhoneValidator : IPhoneValidator
    {
        public bool IsValid(Phone phone)
        {
            return !string.IsNullOrEmpty(phone.Model) && phone.Price > 0;
        }
    }
}
