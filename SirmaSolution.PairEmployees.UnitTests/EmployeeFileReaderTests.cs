using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SirmaSolution.PairEmployees.UnitTests
{
    [TestClass]
    public class EmployeeFileReaderTests
    {
        [TestMethod]
        public void ReadEmployeeFile_FileNotExists()
        {
            string exception = "";

            try
            {
                var employees = EmployeeFileReader.ReadEmployeeFile("c:\\bla bla bla\\bla bla bla\\bla.txt");
            }
            catch (Exception ex)
            {
                exception = ex.Message;
            }

            Assert.AreEqual(exception, "bla.txt file not exists in \"c:\\bla bla bla\\bla bla bla\"");
        }

        [TestMethod]
        public void ReadEmployeeFile_InvalidRecordItems()
        {
            string exception = "";

            string data = "143, 12, 2013-11-01, 2014-01-05, ttttttt";
            string file = System.IO.Path.GetTempFileName();
            System.IO.File.WriteAllText(file, data);

            try
            {
                var employees = EmployeeFileReader.ReadEmployeeFile(file);
            }
            catch (Exception ex)
            {
                exception = ex.Message;
            }
            finally
            {
                System.IO.File.Delete(file);
            }

            Assert.AreEqual(exception, "Invalid \"row\" format, row number 0: 143, 12, 2013-11-01, 2014-01-05, ttttttt");
        }

        [TestMethod]
        public void ReadEmployeeFile_InvalidDateFrom()
        {
            string exception = "";

            string data = "143, 12, 2013-13-01, 2014-01-05";
            string file = System.IO.Path.GetTempFileName();
            System.IO.File.WriteAllText(file, data);

            try
            {
                var employees = EmployeeFileReader.ReadEmployeeFile(file);
            }
            catch (Exception ex)
            {
                exception = ex.Message;
            }
            finally
            {
                System.IO.File.Delete(file);
            }

            Assert.AreEqual(exception, "Invalid \"date from\" format, row number 0: 143, 12, 2013-13-01, 2014-01-05");
        }

        [TestMethod]
        public void ReadEmployeeFile_InvalidDateTo()
        {
            string exception = "";

            string data = "143, 12, 2013-10-01, 2014-21-05";
            string file = System.IO.Path.GetTempFileName();
            System.IO.File.WriteAllText(file, data);

            try
            {
                var employees = EmployeeFileReader.ReadEmployeeFile(file);
            }
            catch (Exception ex)
            {
                exception = ex.Message;
            }
            finally
            {
                System.IO.File.Delete(file);
            }

            Assert.AreEqual(exception, "Invalid \"date to\" format, row number 0: 143, 12, 2013-10-01, 2014-21-05");
        }

        [TestMethod]
        public void ReadEmployeeFile_InvalidDateToLessThanDateFrom()
        {
            string exception = "";

            string data = "143, 12, 2015-10-01, 2014-11-05";
            string file = System.IO.Path.GetTempFileName();
            System.IO.File.WriteAllText(file, data);

            try
            {
                var employees = EmployeeFileReader.ReadEmployeeFile(file);
            }
            catch (Exception ex)
            {
                exception = ex.Message;
            }
            finally
            {
                System.IO.File.Delete(file);
            }

            Assert.AreEqual(exception, "Specified argument was out of the range of valid values. (Parameter 'Invalid \"date from\" and \"date to\" range, row number 0: 143, 12, 2015-10-01, 2014-11-05')");
        }

        [TestMethod]
        public void ReadEmployeeFile_RemoveDefaultHeader()
        {
            string exception = "";

            string data = "EmpID, ProjectID, DateFrom, DateTo\n143, 12, 2011-10-01, 2014-11-05";
            string file = System.IO.Path.GetTempFileName();
            System.IO.File.WriteAllText(file, data);

            var employees = new System.Collections.Generic.List<Employee>();
            try
            {
                employees = EmployeeFileReader.ReadEmployeeFile(file);
            }
            catch (Exception ex)
            {
                exception = ex.Message;
            }
            finally
            {
                System.IO.File.Delete(file);
            }

            Assert.AreEqual(exception, "");
            Assert.AreEqual(employees.Count, 1);
        }
    }
}
