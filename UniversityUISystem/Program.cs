using UniversityBusinessService;
using UniversityModel;

namespace UniversityUISystem
{
    internal class Program
    {
        static List<University> universities = new List<University>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to University Find!");

            UniversityService universityService = new UniversityService();
            universities = universityService.GetUniversities();

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Display Universities");
                Console.WriteLine("2. Search for Universities (by type)");
                Console.WriteLine("3. Sort Universities");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nListed Universities:");
                        DisplayUniversities(universityService.GetUniversities());
                        Console.WriteLine("---------------------------");
                        break;

                    case "2":
                        Console.Write("\nEnter the type of university (state/private): ");
                        string typeToSearch = Console.ReadLine();

                        var foundUniversities = universityService.SearchUniversity(typeToSearch);

                        if (foundUniversities.Count > 0)
                        {
                            Console.WriteLine("\nFound university(s)!");
                            foreach (var foundUniversity in foundUniversities)
                            {
                                List<University> universityList = new List<University> { foundUniversity };
                                DisplayUniversities(universityList);

                            }
                            Console.WriteLine("---------------------------");
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid input.");
                            Console.WriteLine("---------------------------");
                        }
                        break;

                    case "3":
                        Console.Write("\nSort Universities by (name/location/type): ");
                        string sortBy = Console.ReadLine();

                        try
                        {
                            var sortedUniversities = universityService.SortUniversities(sortBy);
                            DisplayUniversities(sortedUniversities);
                            Console.WriteLine("---------------------------");
                        }

                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("\nError: " + ex.Message);
                        }
                        break;

                    case "4":
                        Console.WriteLine("\nExiting program...");
                        return;

                    default:
                        Console.WriteLine("\nInvalid choice.");
                        break;
                }
            }

            static void DisplayUniversities(List<University> universities)
            {
                foreach (var university in universities)
                {
                    Console.WriteLine($"\nName: {university.name}");
                    Console.WriteLine($"    - Location: {university.location}");
                    Console.WriteLine($"    - Type: {university.type}");
                    Console.WriteLine("    - Courses:");
                    string[] courses = university.courses.Split(',');
                    foreach (var course in courses)
                    {
                        Console.WriteLine($"        {course.Trim()}");
                    }
                }
            }
        }
    }
}
