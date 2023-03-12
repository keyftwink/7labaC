using _7laba.brands;

namespace _7laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            F_35 f_35 = new F_35();
            Console.WriteLine(f_35.GetInformation());
            Moscow moscow = new Moscow();
            Console.WriteLine(moscow.GetInformation());
            ChevroletCamaro camaro = new ChevroletCamaro();
            Console.WriteLine(camaro.GetInformation());

        }
    }
}