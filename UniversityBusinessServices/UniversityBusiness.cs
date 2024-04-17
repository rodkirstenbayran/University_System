using UniversityDataService;
using UniversityModel;

namespace UniversityBusinessService
{
    public class UniversityService
    {
        public UniversityData universityData;

        public UniversityService()
        {
            universityData = new UniversityData();
        }

        //display method
        public List<University> GetUniversities()
        {
            return universityData.GetUniversities();
        }

        //search method
        public List<University> SearchUniversity(string type)
        {
            List<University> universities = universityData.universities;
            List<University> foundUniversity = new List<University>();

            foreach (University univer in universities)
            {
                if (univer.type.ToLower().Contains(type.ToLower()))
                {
                    foundUniversity.Add(univer);
                }
            }
            return foundUniversity;
        }

        public List<University> SortUniversities(string sortBy)
        {
            var universities = universityData.GetUniversities();

            switch (sortBy.ToLower())
            {
                case "name":
                    universities.Sort((u1, u2) => string.Compare(u1.name, u2.name));
                    break;
                case "location":
                    universities.Sort((u1, u2) => string.Compare(u1.location, u2.location));
                    break;
                case "type":
                    universities.Sort((u1, u2) => string.Compare(u1.type, u2.type));
                    break;
                default:
                    throw new ArgumentException("Invalid sorting criteria.");
            }

            return universities;
        }

    }
}