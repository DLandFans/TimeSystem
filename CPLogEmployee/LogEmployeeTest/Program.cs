using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using INFX.Timeclock;

namespace LogEmployeeTest
{

    class Program
    {

        static void Main(string[] args)
        {

            //List<Employee> Emps = new List<Employee>();

            //Console.WriteLine("Building Test Employee");

            //Employee E1 = new Employee(8214, "Bob", "Smith", "1234");
            //E1.AddTimePeriod(new TimePeriod() { TimeIn = new DateTime(2016, 05, 07, 07, 00, 00), TimeOut = new DateTime(2016, 05, 07, 10, 30, 00) });
            //E1.AddTimePeriod(new TimePeriod() { TimeIn = new DateTime(2016, 05, 06, 07, 00, 00), TimeOut = new DateTime(2016, 05, 06, 13, 30, 00) });
            //Emps.Add(E1);

            //Employee E2 = new Employee(2313, "John", "Doe", "4321");
            //E2.AddTimePeriod(new TimePeriod() { TimeIn = new DateTime(2016, 05, 07, 06, 00, 00), TimeOut = new DateTime(2016, 05, 07, 9, 30, 00) });
            //E2.AddTimePeriod(new TimePeriod() { TimeIn = new DateTime(2016, 05, 06, 06, 00, 00), TimeOut = new DateTime(2016, 05, 06, 14, 30, 00) });
            //Emps.Add(E2);

            Employees Emp = new Employees();
            //Emp.Write("U:\\OneDrive\\Projects\\text.xml");

            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load("U:\\OneDrive\\Projects\\text.xml");
            //XmlElement root = xmlDoc.DocumentElement;


            //Console.WriteLine(root.ChildNodes[0].Attributes["ID"].Value.ToString());

            //foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes)
            //{
            //    Console.WriteLine(xmlNode.Attributes["ID"].Value);
            //    Console.WriteLine("1");
            //}

            //Emp.Read("U:\\OneDrive\\Projects\\text.xml");

            //Emp.Employee[3].FirstName = "Bobby";

            //Emp.Write("U:\\OneDrive\\Projects\\text.xml");




            Console.ReadLine();



        }
    }
}
