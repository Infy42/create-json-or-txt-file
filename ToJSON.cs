namespace JSONCreator{
    public class JSON{
        public static string ToJSON(string fileName)
        {
            string fName = fileName;

            string path = @$"C:\Users\mis\Desktop\{fName}.json";
            return path;
        }
    }
}