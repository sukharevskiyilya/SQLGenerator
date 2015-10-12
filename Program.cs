using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator.WriteToFile(Generator.GenerateFacultyRows(50), @"E:\3Course\Databases\Laba3\Faculty.sql");
        }
    }
}
