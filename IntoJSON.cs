using Newtonsoft.Json;

namespace JSONCreator
{
    class Converting
    {
        public static string IntoJSON(int ID, string Name, string Sector, int Salary, bool OnHoliday)
        {
            var data = new
            {
                ID = ID,
                Name = Name,
                Sector = Sector,
                Salary = Salary,
                OnHoliday = OnHoliday
            };
            string json = JsonConvert.SerializeObject(data);
            Console.WriteLine(json);

            return json;
        }
    }

}