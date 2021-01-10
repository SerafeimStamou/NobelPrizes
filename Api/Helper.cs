using System;
using System.Linq;
using System.Threading.Tasks;

namespace Api
{
    public class Helper
    {
        public static async Task Load()
        {
            var nobels = await NobelProcessor.GetNobels();
            bool run = true;

            if (nobels != null)
            {
                while (run)
                {
                    Console.WriteLine("Press 1 to see all the winners and prizes,press 2 to search by winner's name or press 3 to search by nobel's category");
                    Console.WriteLine("Press 0 to exit program");
                    string choice = Console.ReadLine();

                    if (choice.Equals("0"))
                        run = false;

                    if (choice.Equals("1"))
                        GetAll(nobels);

                    if (choice.Equals("2"))
                        GetByName(nobels);

                    if (choice.Equals("3"))
                        GetByCategory(nobels);
                }
            }
        }



        public static void GetAll(NobelModel nobels)
        {
            foreach (var nobel in nobels.Laureates)
            {
                Console.WriteLine("Name: {0}", nobel.KnownName.En);
                Console.WriteLine("Date of Birth: {0}", nobel.BirthInfo.BirthDate);
                Console.WriteLine("Gender: {0}", nobel.Gender);
                Console.WriteLine("Birth Place: {0},{1}", nobel.BirthInfo.PlaceInfo.city.CityName, nobel.BirthInfo.PlaceInfo.country.CountryName);
                Console.WriteLine();
                Console.WriteLine("Information about prize:");
                Console.WriteLine("Category: {0}", nobel.award[0].Category.CategoryName);
                Console.WriteLine("Category full name: {0}", nobel.award[0].CategoryFullName.FullName);
                Console.WriteLine("Motivation: {0}", nobel.award[0].MotivationText.PrizeMotivation);
                Console.WriteLine("Year: {0}", nobel.award[0].AwardYear);
                Console.WriteLine("Full Date: {0}", nobel.award[0].DateAwarded);
                Console.WriteLine("Status: {0}", nobel.award[0].PrizeStatus);
                Console.WriteLine("---------------------------------------------------------");
            }
        }

        public static void GetByName(NobelModel nobels)
        {
            Console.WriteLine("Enter a name (for example Albert Einstein):");
            string name = Console.ReadLine();

            var result = nobels.Laureates.Find(n => n.KnownName.En.Equals(name));

            Console.WriteLine();
            Console.WriteLine("Name: {0}", result.KnownName.En);
            Console.WriteLine("Date of Birth: {0}", result.BirthInfo.BirthDate);
            Console.WriteLine("Gender: {0}", result.Gender);
            Console.WriteLine("Birth Place: {0},{1}", result.BirthInfo.PlaceInfo.city.CityName, result.BirthInfo.PlaceInfo.country.CountryName);
            Console.WriteLine();
            Console.WriteLine("Information about prize:");
            Console.WriteLine("Category: {0}", result.award[0].Category.CategoryName);
            Console.WriteLine("Category full name: {0}", result.award[0].CategoryFullName.FullName);
            Console.WriteLine("Motivation: {0}", result.award[0].MotivationText.PrizeMotivation);
            Console.WriteLine("Year: {0}", result.award[0].AwardYear);
            Console.WriteLine("Full Date: {0}", result.award[0].DateAwarded);
            Console.WriteLine("Status: {0}", result.award[0].PrizeStatus);
        }

        public static void GetByCategory(NobelModel nobels)
        {
            Console.WriteLine("Enter category(for example Physics):");
            string category = Console.ReadLine();

            var result = nobels.Laureates.Where(n => n.award[0].Category.CategoryName.Equals(category)).ToList();

            foreach (var nobel in result)
            {
                Console.WriteLine("Name: {0}", nobel.KnownName.En);
                Console.WriteLine("Date of Birth: {0}", nobel.BirthInfo.BirthDate);
                Console.WriteLine("Gender: {0}", nobel.Gender);
                Console.WriteLine("Birth Place: {0},{1}", nobel.BirthInfo.PlaceInfo.city.CityName, nobel.BirthInfo.PlaceInfo.country.CountryName);
                Console.WriteLine();
                Console.WriteLine("Information about prize:");
                Console.WriteLine("Category: {0}", nobel.award[0].Category.CategoryName);
                Console.WriteLine("Category full name: {0}", nobel.award[0].CategoryFullName.FullName);
                Console.WriteLine("Motivation: {0}", nobel.award[0].MotivationText.PrizeMotivation);
                Console.WriteLine("Year: {0}", nobel.award[0].AwardYear);
                Console.WriteLine("Full Date: {0}", nobel.award[0].DateAwarded);
                Console.WriteLine("Status: {0}", nobel.award[0].PrizeStatus);
                Console.WriteLine("---------------------------------------------------------");
            }
        }
    }
}
