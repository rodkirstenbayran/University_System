using UniversityModel;

namespace UniversityDataService
{
    public class UniversityData
    {
        public List<University> universities = new List<University>();

        public UniversityData()
        {
            CreateData();
        }

        private void CreateData()
        {
            University university1 = new University
            {
                name = "Polytechnic University of the Philippines",
                location = "Binan, Laguna",
                type = "State University",
                courses = "Bachelor in Elementary Education, BS in Accountancy, BS in Business Administration major in Human Resource Management, BS in Computer Engineering, BS in Information Technology, Bachelor of Secondary Education major in English, Bachelor of Secondary Education major in Social Studies, Diploma in Computer Engineering Technology, Diploma in Information Communication Technology"
            };

            University university2 = new University
            {
                name = "Saint Michael's College of Laguna",
                location = "Binan, Laguna",
                type = "Private University",
                courses = "Bachelor of Science in Business Administration, Bachelor of Secondary Education, Bachelor of Elementary Education, Bachelor of Science in Nursing, BS in Hospitality Management"
            };

            University university3 = new University
            {
                name = "University of Perpetual Help System Laguna",
                location = "Binan, Laguna",
                type = "Private University",
                courses = "BS in Nursing, BS in Business Administration major in Human Resource Management, BS in Tourism Management, BS in Accountancy, BS in Information Technology, BS in Psychology, BS in Biology, BS in Pharmacy, Bachelor in Elementary Education"
            };

            University university4 = new University
            {
                name = "La Consolacion College",
                location = "Binan, Laguna",
                type = "Private University",
                courses = "BS in Business Administration major in Human Resource Management, BS in Tourism Management, BS in Accountancy, BS in Information Technology, BS in Psychology , Bachelor in Elementary Education, BS in Computer Science"
            };

            University university5 = new University
            {
                name = "AMA Computer University",
                location = "Binan, Laguna",
                type = "Private University",
                courses = "BA in Economics, BA in English, BA in Mass Communication, BS in Accountancy, BS in Computer Engineering, BS in Computer Science, BS in Information Technology, BA in Psychology"
            };

            University university6 = new University
            {
                name = "University of the Philippines",
                location = "Los Banos, Laguna",
                type = "State University",
                courses = "BS in Agriculture, BS in Forestry, BS in Biology, BS in Chemistry, BS in Civil Engineering, BS in Computer Science, BS in Economics, AB in Sociology, BS in Nutrition"
            };

            University university7 = new University
            {
                name = "Laguna State Polytechnic University",
                location = "San Pablo, Laguna",
                type = "State University",
                courses = "Bachelor in Elementary Education, BS in Business Administration major in Human Resource Management, BS in Accountancy, BS in Computer Science, BS in Information Technology, BS in Criminology, BS in Psychology, BS in Biology, BS in Tourism Management, BS in Office Administration"
            };

            University university8 = new University
            {
                name = "The Lyceum of the Philippines",
                location = "Calamba Laguna",
                type = "Private University",
                courses = "BS in Civil Engineering, BS in Business Administration, BS in Accountancy, BS in Computer Science, BS in Information Technology, BS in Criminology, BS in Psychology, BS in Biology, BS in Tourism Management, BS in Office Administration, BS in Entrepreneurship, BS in Legal Management, BS in Medical Technology"
            };

            University university9 = new University
            {
                name = "Laguna College",
                location = "San Pablo, Laguna",
                type = "Private University",
                courses = "Bachelor in Elementary Education, BS in Business Administration major in Human Resource Management, BS in Accountancy, BS in Computer Science, BS in Information Technology, BS in Criminology, BS in Psychology, BS in Biology, BS in Tourism Management, BS in Office Administration, BS in Nursing, BS in Industrial Engineering, AB in English"
            };

            University university10 = new University
            {
                name = "San Pedro College of Business Administration",
                location = "San Pedro, Laguna",
                type = "Private University",
                courses = "BSEd in English, BSEd in Mathematics, BS in Accountancy, BS in Computer Science, BS in Information Technology, BS in Hospitality Management, BS in Psychology, BS in Internal Auditing, BS in Tourism Management, BS in Business Administration major in Human Resource Management, BS in Industrial Engineering"
            };

            universities.Add(university1);
            universities.Add(university2);
            universities.Add(university3);
            universities.Add(university4);
            universities.Add(university5);
            universities.Add(university6);
            universities.Add(university7);
            universities.Add(university8);
            universities.Add(university9);
            universities.Add(university10);
        }

        public List<University>GetUniversities()
        {
            return universities;
        }
    }
    }
