namespace JSONCreator
{
    public class Sector{
        public static string ChoosingSector(int sectorChoice){
            int S = sectorChoice;
            string choice = "";
            switch(S){
                case 1: choice = "IT"; break;
                case 2: choice = "Software Engineer"; break;
                case 3: choice = "Full-stack Web Developer"; break;
                case 4: choice = "Data Scientist"; break;
                case 5: choice = "DevOps Engineer"; break;
                case 6: choice = "QA Tester"; break;
                default: choice = "Unassigned"; break;
            }
            return choice;
        }
    }
}