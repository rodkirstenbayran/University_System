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
            var sortedUniversities = new List<University>(universities);

            switch (sortBy.ToLower())
            {
                case "name":
                    sortedUniversities.Sort((u1, u2) => string.Compare(u1.name, u2.name));
                    break;
                case "location":
                    sortedUniversities.Sort((u1, u2) => string.Compare(u1.location, u2.location));
                    break;
                case "type":
                    sortedUniversities.Sort((u1, u2) => string.Compare(u1.type, u2.type));
                    break;
                default:
                    throw new ArgumentException("Invalid sorting criteria.");
            }

            return sortedUniversities;
        }
    }
}