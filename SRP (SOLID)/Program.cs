using SRP__SOLID_.Services;

namespace SRP__SOLID_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MobileStore store = new MobileStore(new ConsolePhoneReader(),
                new TextPhoneSaver(), new GeneralPhoneValidator(), new GeneralPhoneBinder());

            store.Process();
        }
    }
}
