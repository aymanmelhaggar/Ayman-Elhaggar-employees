using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirmaSolution.PairEmployees
{
    public static class EmployeeFileReader
    {
        public static string DateFormat { get; set; } = "yyyy-MM-dd";
        public static List<Employee> ReadEmployeeFile(string path)
        {
            if (!System.IO.File.Exists(path)) throw new System.IO.IOException($"{System.IO.Path.GetFileName(path)} file not exists in \"{System.IO.Path.GetDirectoryName(path)}\"");

            var employeeFileData = System.IO.File.ReadAllLines(path).ToList();

            if (employeeFileData[0].ToLower() == "empid, projectid, datefrom, dateto") employeeFileData.RemoveAt(0);

            var employees = new List<Employee>();

            foreach (var employeeFileDataRecord in employeeFileData)
            {
                var employeeFileDataRecordItems = employeeFileDataRecord.Split(',');

                if (employeeFileDataRecordItems.Length != 4) throw new FormatException($"Invalid \"row\" format, row number {employeeFileData.IndexOf(employeeFileDataRecord)}: {employeeFileDataRecord}");

                Employee employee = new Employee()
                {
                    EmpID = employeeFileDataRecordItems[0].Trim(),
                    ProjectID = employeeFileDataRecordItems[1].Trim(),
                };

                string dateFromStr = employeeFileDataRecordItems[2].Trim();
                if (dateFromStr.ToLower() != "null")
                    try
                    {
                        employee.DateFrom = GetDate(dateFromStr);
                    }
                    catch
                    {
                        throw new FormatException($"Invalid \"date from\" format, row number {employeeFileData.IndexOf(employeeFileDataRecord)}: {employeeFileDataRecord}");
                    }

                string dateToStr = employeeFileDataRecordItems[3].Trim();
                if (dateToStr.ToLower() != "null")
                    try
                    {
                        employee.DateTo = GetDate(dateToStr);
                    }
                    catch
                    {
                        throw new FormatException($"Invalid \"date to\" format, row number {employeeFileData.IndexOf(employeeFileDataRecord)}: {employeeFileDataRecord}");
                    }

                if (employee.DateTo < employee.DateFrom) throw new ArgumentOutOfRangeException($"Invalid \"date from\" and \"date to\" range, row number {employeeFileData.IndexOf(employeeFileDataRecord)}: {employeeFileDataRecord}");

                employees.Add(employee);
            }

            return employees;
        }

        private static DateTime GetDate(string dateString)
        {
            DateTime date = DateTime.Now;

            if (DateFormat.ToLower() != "auto" && !DateTime.TryParseExact(dateString, DateFormat, null, System.Globalization.DateTimeStyles.None, out date)) throw new Exception("Invalid Date Format");
            else if (DateFormat.ToLower() == "auto" && !DateTime.TryParse(dateString, null, System.Globalization.DateTimeStyles.None, out date)) throw new Exception("Invalid Date Format");

            return date.Date;
        }
    }
}
