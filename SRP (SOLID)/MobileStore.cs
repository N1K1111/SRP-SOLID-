using SRP__SOLID_.Interfaces;
using SRP__SOLID_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP__SOLID_
{
    internal class MobileStore
    {
        List<Phone> phones = new List<Phone>();

        public IPhoneBinder Binder { get; set; }
        public IPhoneReader Reader {  get; set; }
        public IPhoneSaver Saver { get; set; }
        public IPhoneValidator Validator { get; set; }

        public MobileStore(IPhoneReader reader, IPhoneSaver saver, IPhoneValidator validator, IPhoneBinder binder)
        {
            Reader = reader;
            Saver = saver;
            Validator = validator;
            Binder = binder;
        }

        public void Process()
        {
            string?[] data = Reader.GetInputData();
            Phone phone = Binder.CreatePhone(data);
            if (Validator.IsValid(phone))
            {
                phones.Add(phone);
                Saver.Save(phone,"store.txt");
                Console.WriteLine("Данные успешно обработаны");
            }
            else Console.WriteLine("Некорректные данные");
        }
    }
}
