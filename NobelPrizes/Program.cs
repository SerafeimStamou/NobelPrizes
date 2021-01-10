using static Api.ApiHelper;
using static Api.Helper;

namespace NobelPrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeClient();
            Load().Wait();
        }
    }
}
