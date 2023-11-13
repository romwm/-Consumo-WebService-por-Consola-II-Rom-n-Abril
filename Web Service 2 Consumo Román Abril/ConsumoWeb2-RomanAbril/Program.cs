using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoWeb2_RomanAbril
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InfoPaises.CountryInfoService client = new InfoPaises.CountryInfoService();
            var respuesta = client.FullCountryInfoAllCountries();
            Console.WriteLine("El país es: ");
            Console.WriteLine(respuesta.First().sName);
            Console.WriteLine("La capital es: ");
            Console.WriteLine(respuesta.First().sCapitalCity);
            Console.WriteLine("Su divisa es: ");
            Console.WriteLine(respuesta.First().sCurrencyISOCode);
        }
    }
}
