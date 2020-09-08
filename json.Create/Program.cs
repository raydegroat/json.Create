using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializeEmployee();
            SerializeStudent();
        }
        public static void SerializeEmployee()
        {
            Employee emp = new Employee();
            string JSONresult = JsonConvert.SerializeObject(emp);

            string path = @"C:\json\employee.json";

            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }
        }
        public static void SerializeStudent()
        {
            Student stu = new Student();
            string JSONresult2 = JsonConvert.SerializeObject(stu);

            string path2 = @"C:\json\student.json";

            if (File.Exists(path2))
            {
                File.Delete(path2);
                using (var tw = new StreamWriter(path2, true))
                {
                    tw.WriteLine(JSONresult2.ToString());
                    tw.Close();
                }
            }
            else if (!File.Exists(path2))
            {
                using (var tw = new StreamWriter(path2, true))
                {
                    tw.WriteLine(JSONresult2.ToString());
                    tw.Close();
                }
            }
        }
    }
}
