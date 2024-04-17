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
                courses = "Bachelor of Elementary Education, BSA, BSBA-HRM, BSCpE, BSIE, BSIT, BSEDEN, BSEDSS, DCET, DICT"
            };

            University university2 = new University
            {
                name = "Saint Michael's College of Laguna",
                location = "Binan, Laguna",
                type = "Private University",
                courses = "BSBA, BSIT, BSPsy, BEED, BSN, BSCrim"
            };

            University university3 = new University
            {
                name = "University of Perpetual Help System Laguna",
                location = "Binan, Laguna",
                type = "Private University",
                courses = "BSN, BS-HRM, BSTM, BSA, BSBA, BSIT, BSPsy, BSBio, BSPharma, BEED"
            };

            University university4 = new University
            {
                name = "La Consolacion College",
                location = "Binan, Laguna",
                type = "Private University",
                courses = "BS-HRM, BSTM, BSA, BSBA, BSIT, BSPsy, BEED, BSCS"
            };

            University university5 = new University
            {
                name = "AMA Computer University",
                location = "Binan, Laguna",
                type = "Private University",
                courses = "BA in Economics, BA in English, BA in MassComm, BSA, BSCE, BSCS, BSIT,BAPsy"
            };

            University university6 = new University
            {
                name = "University of the Philippines",
                location = "Los Banos, Laguna",
                type = "State University",
                courses = "BS in Agriculture, BS in Forestry, BSBio, BSChem, BS in Civil Engineering, BSCS, BS in Economics, AB in Sociology, BS in Nutrition"
            };

            University university7 = new University
            {
                name = "Laguna State Polytechnic University",
                location = "San Pablo, Laguna",
                type = "State University",
                courses = "BEED, BS-HRM, BSBA, BSA, BSCS, BSIT, BSCrim, BSPsy, BSBio, BS in Tourism, BS in Office Administration"
            };

            universities.Add(university1);
            universities.Add(university2);
            universities.Add(university3);
            universities.Add(university4);
            universities.Add(university5);
            universities.Add(university6);
            universities.Add(university7);
        }

        public List<University>GetUniversities()
        {
            return universities;
        }
    }
    }
