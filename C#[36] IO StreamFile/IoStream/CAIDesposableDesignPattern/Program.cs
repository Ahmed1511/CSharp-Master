using System;
using System.Net.Http;

namespace CAIDesposableDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) not Recommended.
            //CurrencyService currency = new CurrencyService();
            //var result = currency.GetCurrencies();
            //currency.Dispose();
            //Console.WriteLine(result);


            // 2) Recommended.
            //CurrencyService currency = null;
            //try
            //{
            //    currency = new CurrencyService();
            //    var result = currency.GetCurrencies();
            //    Console.WriteLine(result);

            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Error");
            //}
            //finally
            //{
            //    currency?.Dispose();
            //}

            // 3) More Recommended

            using (CurrencyService currency = new CurrencyService())
            {
                var result = currency.GetCurrencies();
                Console.WriteLine(result);
            }
        }
    }

    public class CurrencyService : IDisposable
    {
        private readonly HttpClient httpClient;
        private bool _dispose = false;
        public CurrencyService()
        {
            httpClient = new HttpClient();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_dispose)
            {
                return;
            }

            if (disposing)
            {
                httpClient.Dispose();
            }

            _dispose = true;

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~CurrencyService()
        {
            Dispose(false);
        }
        public string GetCurrencies()
        {
            string url = "https://coinbase.com/api/v2/currencies";
            var result = httpClient.GetStringAsync(url).Result;
            return result;
        }
    }
}
