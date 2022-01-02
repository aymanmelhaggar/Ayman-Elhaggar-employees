using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirmaSolution.PairEmployees.UnitTests
{
    [TestClass]
    public class ProjectEmployeePairFinderTests
    {
        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartBeforeEmp2Start_AndFinishBeforeEmp2Start()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 03), DateTo = new DateTime(2020, 01, 04) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 0);
        }
        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartBeforeEmp2Start_AndFinishOnEmp2Start()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 03), DateTo = new DateTime(2020, 01, 05) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 1);
            Assert.AreEqual(finds[0].DaysWorked, 1);
        }
        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartBeforeEmp2Start_AndFinishAfterEmp2StartButBeforeEmp2End()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 03), DateTo = new DateTime(2020, 01, 06) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 1);
            Assert.AreEqual(finds[0].DaysWorked, 2);
        }
        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartBeforeEmp2Start_AndFinishWithEmp2End()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 03), DateTo = new DateTime(2020, 01, 07) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 1);
            Assert.AreEqual(finds[0].DaysWorked, 3);
        }
        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartBeforeEmp2Start_AndFinishAfterEmp2End()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 03), DateTo = new DateTime(2020, 01, 08) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 1);
            Assert.AreEqual(finds[0].DaysWorked, 3);
        }



        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartWithEmp2Start_AndFinishWithEmp2Start()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 05) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 1);
            Assert.AreEqual(finds[0].DaysWorked, 1);
        }
        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartWithEmp2Start_AndFinishAfterEmp2StartButBeforeEmp2End()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 06) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 1);
            Assert.AreEqual(finds[0].DaysWorked, 2);
        }
        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartWithEmp2Start_AndFinishWithEmp2End()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 1);
            Assert.AreEqual(finds[0].DaysWorked, 3);
        }
        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartWithEmp2Start_AndFinishAfterEmp2End()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 08) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 1);
            Assert.AreEqual(finds[0].DaysWorked, 3);
        }




        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartAfterEmp2StartButBeforeEmp2End_AndFinishBeforeEmp2End()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 06), DateTo = new DateTime(2020, 01, 06) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 1);
            Assert.AreEqual(finds[0].DaysWorked, 1);
        }
        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartAfterEmp2StartButBeforeEmp2End_AndFinishWithEmp2End()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 06), DateTo = new DateTime(2020, 01, 07) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 1);
            Assert.AreEqual(finds[0].DaysWorked, 2);
        }
        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartAfterEmp2StartButBeforeEmp2End_AndFinishAfterEmp2End()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 06), DateTo = new DateTime(2020, 01, 08) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 1);
            Assert.AreEqual(finds[0].DaysWorked, 2);
        }



        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartOnEmp2End_AndFinishWithEmp2End()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 07), DateTo = new DateTime(2020, 01, 07) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 1);
            Assert.AreEqual(finds[0].DaysWorked, 1);
        }
        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartOnEmp2End_AndFinishAfterEmp2End()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 07), DateTo = new DateTime(2020, 01, 08) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 1);
            Assert.AreEqual(finds[0].DaysWorked, 1);
        }


        [TestMethod]
        public void GetProjectEmployeePairs_Emp1StartAfterEmp2End_AndFinishAfterEmp2End()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 08), DateTo = new DateTime(2020, 01, 09) };

            List<Employee> employees = new List<Employee>() { emp1, emp2 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 0);
        }


        [TestMethod]
        public void GetProjectEmployeePairs_MoreThanTwoEmpMatch()
        {
            Employee emp1 = new Employee() { EmpID = "1", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp2 = new Employee() { EmpID = "2", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };
            Employee emp3 = new Employee() { EmpID = "3", ProjectID = "1", DateFrom = new DateTime(2020, 01, 05), DateTo = new DateTime(2020, 01, 07) };

            List<Employee> employees = new List<Employee>() { emp1, emp2, emp3 };
            var finds = ProjectEmployeePairFinder.GetProjectEmployeePairs(employees);

            Assert.AreEqual(finds.Count, 3);
        }
    }
}
