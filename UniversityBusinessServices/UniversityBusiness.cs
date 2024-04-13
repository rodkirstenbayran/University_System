using UniversityDataService;
using UniversityModel;

namespace UniversityBusinessService
{
    public class UniversityService
    {
        private UniversityData universityData;

        public UniversityService()
        {
            universityData = new UniversityData();
        }

        //display method
        public string GetUniversityData()
        {
            return universityData.DisplayUniversities();
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

    }
}