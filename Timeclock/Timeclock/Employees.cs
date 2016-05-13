using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace INFX.Timeclock
{
    public class Employees
    {
        private List<Employee> _employees;
        XmlWriter writer;
        XmlReader reader;

        public List<Employee> EmployeeList { get { return _employees; } }

        public Employees()
        {
            _employees = new List<Employee>();
        }

        public Employees(List<Employee> employees)
        {
            _employees = employees;
        }

        public void Read(string filename)
        {
            reader = XmlReader.Create(filename);

            bool newEmployee = false;
            Employee tempEmp = new Employee();
            TimePeriod tempTP = new TimePeriod();

            while(reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Employee":
                            if (newEmployee) throw new Exception("MalformedEmployeeXML");
                            newEmployee = true;
                            tempEmp = new Employee();
                            if (reader.HasAttributes)
                                tempEmp.ID = reader.GetAttribute("ID");
                            break;
                        case "FirstName":
                            if (newEmployee) tempEmp.FirstName = reader.ReadString();
                            break;
                        case "LastName":
                            if (newEmployee) tempEmp.LastName = reader.ReadString();
                            break;
                        case "Code":
                            if (newEmployee) tempEmp.AddLoginCode(reader.ReadString());
                            break;
                        //case "TimePeriods":
                        //    if (newTP) throw new Exception("MalformedTimePeriods");
                        //    newTP = true;
                        //    break;
                        case "TimePeriod":
                            if (newEmployee)
                            {
                                if (reader.HasAttributes)
                                {
                                    tempEmp.AddTimePeriod(new TimePeriod() { TimeIn = DateTime.Parse(reader.GetAttribute("Begin")), TimeOut = DateTime.Parse(reader.GetAttribute("End")) });
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }

                if (reader.NodeType == XmlNodeType.EndElement)
                {
                    switch (reader.Name)
                    {
                        case "Employee":
                            newEmployee = false;
                            _employees.Add(tempEmp);
                            break;
                        //case "TimePeriods":
                        //    Console.WriteLine("End of TimePeriods");
                        //    break;
                        default:
                            break;
                    }
                }
            }
            reader.Close();

        }

        public void Write(string filename)
        {
            if (_employees.Count == 0) throw new Exception("NoEmployeesToWrite");

            XmlWriterSettings objSetting = new XmlWriterSettings();
            objSetting.Indent = true;
            objSetting.IndentChars = ("\t");
            objSetting.NewLineOnAttributes = false;

            using (writer = XmlWriter.Create(filename, objSetting))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Employees");

                foreach (Employee emp in _employees)
                {
                    writer.WriteStartElement("Employee");
                    writer.WriteAttributeString("ID", emp.ID.ToString());
                    writer.WriteStartElement("FirstName");
                    writer.WriteString(emp.FirstName);
                    writer.WriteEndElement();
                    writer.WriteStartElement("LastName");
                    writer.WriteString(emp.LastName);
                    writer.WriteEndElement();
                    writer.WriteStartElement("Code");
                    writer.WriteString(emp.LoginCode);
                    writer.WriteEndElement();

                    if (emp.Periods.Count > 0)
                    {
                        writer.WriteStartElement("TimePeriods");
                        foreach (TimePeriod tp in emp.Periods)
                        {
                            writer.WriteStartElement("TimePeriod");
                            writer.WriteAttributeString("Begin", tp.TimeIn.ToString());
                            writer.WriteAttributeString("End", tp.TimeOut.ToString());
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }

        }
    }
}
