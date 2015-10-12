using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SQLGenerator
{
    class Generator
    {

        #region Months
        private static List<string> Months = new List<string>
        {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "June",
            "July",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"
        };
        #endregion

        #region Types
        private static List<string> Types = new List<string>
        {
            "Lecture",
            "Laba",
            "Seminar",
            "Practice"
        };
        #endregion

        #region Posts
        private static List<string> Posts = new List<string>
        {
            "Assistant",
            "Teacher",
            "Docent",
            "Proffesor"
        };
        #endregion

        #region Names
        private static List<string> Names = new List<string>
        {
            "Andrew",
            "Avraam",
            "Iuda",
            "Isuse",
            "Budda",
            "Adolf",
            "Max",
            "William",
            "Ivan",
            "Egor",
            "Illya",
            "Kostya",
            "Tom"
        };
        #endregion

        public static void WriteToFile(List<string> queries, string path)
        {
            StreamWriter streamWriter = new StreamWriter(new FileStream(path, FileMode.Create));
            queries.ForEach(x => streamWriter.WriteLine(x));
            streamWriter.Close();
        }

        public static List<string> GenerateFacultyRows(int number)
        {
            List<string> result = new List<string>();
            Random random = new Random();
            for (int i = 0; i < number; i++)
            {
                string facultyName = String.Format("{0}{1}", (char)(65 + random.Next(25)), (char)(65 + random.Next(25)));
                string building = (1 + random.Next(9)).ToString();
                string fund = (100000 + random.Next(99999)).ToString();
                string query = String.Format("INSERT INTO FACULTY VALUES({0},'{1}' ,null, '{2}', {3}.00);", i, facultyName, building, fund);
                result.Add(query);
            }
            return result;
        }
    }
}
