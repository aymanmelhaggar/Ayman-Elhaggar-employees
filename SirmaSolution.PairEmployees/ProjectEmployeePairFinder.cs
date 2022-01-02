using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirmaSolution.PairEmployees
{
    public static class ProjectEmployeePairFinder
    {
        public static List<ProjectEmployeePair> GetProjectEmployeePairs(List<Employee> employees)
        {
            List<ProjectEmployeePair> projectEmployeePairs = new List<ProjectEmployeePair>();

            for (int i = 0; i <= employees.Count - 2; i++)
            {
                List<Employee> employeesToMatch = employees.Skip(i + 1).Where(e => e.ProjectID == employees[i].ProjectID && e.EmpID != employees[i].EmpID).ToList();
                for (int ii = 0; ii <= employeesToMatch.Count - 1; ii++)
                    if (
                            //Employee 1 start before or with employee 2 and end after or the same day employee 2 start
                            (employees[i].DateFrom <= employeesToMatch[ii].DateFrom && employees[i].DateTo >= employeesToMatch[ii].DateFrom) ||
                            //Employee 1 start after employee 2 start work and finish before last day employee 2 work
                            (employees[i].DateFrom > employeesToMatch[ii].DateFrom && employees[i].DateFrom <= employeesToMatch[ii].DateTo)
                    )
                    {
                        DateTime startDate = employees[i].DateFrom <= employeesToMatch[ii].DateFrom ? employeesToMatch[ii].DateFrom : employees[i].DateFrom;
                        DateTime endDate = employees[i].DateTo >= employeesToMatch[ii].DateTo ? employeesToMatch[ii].DateTo : employees[i].DateTo;

                        ProjectEmployeePair projectEmployeePair = new ProjectEmployeePair()
                        {
                            EmpID1 = employees[i].EmpID,
                            EmpID2 = employeesToMatch[ii].EmpID,
                            ProjectID = employees[i].ProjectID,
                            DaysWorked = (endDate - startDate).Days + 1
                        };

                        projectEmployeePairs.Add(projectEmployeePair);
                    }
            }

            return projectEmployeePairs;
        }
    }
}
