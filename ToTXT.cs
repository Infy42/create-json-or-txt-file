namespace JSONCreator{

    public class TXT{
        public static string ToTXT(string fileName)
        {
            string fName = fileName;

            string path = @$"C:\Users\mis\Desktop\{fName}.txt";
            return path;
        }
    }
}

