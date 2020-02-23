﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Text;
using System.Linq;

namespace lab1
{
    [XmlInclude(typeof(Waged))]
    [XmlInclude(typeof(Salaried))]
    public abstract class OrganisationBC //abstract means that it's just a base class, it can contain abstract methods
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public string Bday { get; set; }
        public string Post { get; set; }
        public double Wage { get; set; }
        public double Bounty { get; set; }
        public double Earnings { get; set; }
        public double TotalPayment { get; set; }
        public abstract void Payment();
        public override string ToString() //overrides ToString() method in order to output string that contains multiple vars
        {
            return ID + " " + Type + " " + Surname + " " + Name + " " + LastName + " " + Bday + " " + Post + " " + Wage + " " + Bounty + " " + Earnings;
        }
        public class Waged : OrganisationBC //derived from abstract class organisationbc
        {
            public override void Payment()
            {
                Earnings = Wage * 20.8 * 8 + Bounty;
            }
        }
        public class Salaried : OrganisationBC
        {
            public override void Payment()
            {
                Earnings = Wage + Bounty;
            }
        }
        internal class VoidMain
        {
            public static List<OrganisationBC> EmployeesList { get; } = new List<OrganisationBC>();
            private static void SerializeObject()
            {
                XmlSerializer Serializer = new XmlSerializer(typeof(List<OrganisationBC>)); //create an xmlserializer to serialize string int xml text
                Stream filestream = new FileStream(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "hehe.xml"), FileMode.Create); //open a filestream
                XmlWriter Writer = new XmlTextWriter(filestream, Encoding.Unicode); //serialize using the XmlTextWriter
                Serializer.Serialize(Writer, VoidMain.EmployeesList);
                Writer.Close();
                Console.WriteLine("\nFile is accessible via path: \"" + Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "/hehe.xml\""));
            }
            private static void AddToList()
            {
                string line = Console.ReadLine();
                string[] fields = line.Split(' ');
            wrongpayment:
                if (fields[1] == "Waged")
                {
                    Waged waged = new Waged { ID = int.Parse(fields[0]), Type = fields[1], Surname = fields[2], Name = fields[3], LastName = fields[4], Bday = fields[5], Post = fields[6], Wage = double.Parse(fields[7]), Bounty = double.Parse(fields[8]) };
                    waged.Payment();
                    VoidMain.EmployeesList.Add(waged);
                }
                else if (fields[1] == "Salaried")
                {
                    Salaried salaried = new Salaried { ID = int.Parse(fields[0]), Type = fields[1], Surname = fields[2], Name = fields[3], LastName = fields[4], Bday = fields[5], Post = fields[6], Wage = double.Parse(fields[7]), Bounty = double.Parse(fields[8]) };
                    salaried.Payment();
                    VoidMain.EmployeesList.Add(salaried);
                }
                else
                {
                    Console.WriteLine("Wrong payment type! Specify it again separately: ");
                    fields[1] = Console.ReadLine();
                    goto wrongpayment;
                }
            }
            private static void SortList()
            {

            }
            private static int Main(string[] args)
            {
                while (true)
                {
                    SortList();
                badinput:
                    var i = Console.ReadLine();
                    switch (i)
                    {
                        case "0": return (0);
                        case "1":
                            {
                                Console.WriteLine();
                                Console.WriteLine("Surname Name LastName Bday Post Wage Bounty Earnings");
                                foreach (OrganisationBC listline in EmployeesList)
                                {
                                    Console.WriteLine(listline);
                                }
                            }
                            break;
                        case "2":
                            Console.WriteLine();
                            break;
                        case "3":
                            Console.WriteLine();
                            break;
                        case "4":
                            AddToList();
                            break;
                        case "5":
                            SerializeObject();
                            break;
                        default:
                            {
                                Console.WriteLine("Wrong choice! Try again:");
                                goto badinput;
                            }
                    }
                }
            }
        }
    }
}

/*
         if (type == false)
         {
             summary=20.8*8*stake + Bounty;
         }
         else
         {
            OrganisationBC.TotalPayment = 1;
             summary=stake;
         }
                         //int idx = VoidMain.EmployeesList.IndexOf("Nipun Tomar");
                //throw new NotImplementedException();
                // foreach (OrganisationBC listline in VoidMain.EmployeesList)
                //{
                //TotalPayment += Earnings;
                //if (this.GetType().Name == "Waged") Console.WriteLine("WAGEDDDDDDDDDD");
                // if (this.GetType().Name == "Salaried") Console.WriteLine("SLRDDDDDDDDDDDDDDD");
                // Console.WriteLine(this.GetType().Name + "dddddddddddddddd");

                // }
         
 * //VoidMain.EmployeesList.Add(new Salaried { ID = 1, Type = "Waged", Surname = "Ryabuhin", Name = "Kesha", LastName = "Andreevich", Bday = "09.04.2001", Post = "Janitor", Wage = 2281337.1488, Bounty = 1337.228, Earnings = 111222 });
                //VoidMain.EmployeesList.Add(new Waged { ID = 2, Type = "Salaried", Surname = "Ilyas", Name = "Samsonovich", LastName = "Kopirkin", Bday = "11.01.2009", Post = "SEO NA'VI", Wage = 435634654, Bounty = 1324, Earnings = 111222 });
                VoidMain.EmployeesList.Add(new Salaried { ID = 3, Type = "Salaried", Surname = "Sergeevich", Name = "Artem", LastName = "Sergeevich", Bday = "12.12.2012", Post = "Bomzh", Wage = 767578488, Bounty = 133453, Earnings = 111222 });
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;
    using System.Xml;
    using System.Text;

    namespace lab1
    {
        [XmlInclude(typeof(Waged))]
        [XmlInclude(typeof(Salaried))]
        public abstract class OrganisationBC //abstract means that it's just a base class, it can contain abstract methods
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Post { get; set; }
            public double Wage { get; set; }
     public static double Payment (bool type, double stake, out double summary, out refrtotal)
         {
             if (type == false)
             {
                 summary=20.8*8*stake;
                 //rfrtotal=
             }
             else
             {
                 summary=stake;
             }
         }

public class Waged : OrganisationBC //derived from abstract class organisationbc
        {

        }
        public class Salaried : OrganisationBC
        {

        }
        public class EmployeesList
        {
            public List<OrganisationBC> Employees { get; } = new List<OrganisationBC>();
        }
        internal class VoidMain
        {
            private static EmployeesList List = new EmployeesList();
            private static void SerializeObject()
            {
                XmlSerializer Serializer = new XmlSerializer(typeof(List<OrganisationBC>)); //create an xmlserializer to serialize string int xml text
                Stream filestream = new FileStream(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "hehe.xml"), FileMode.Create); //open a filestream
                XmlWriter Writer = new XmlTextWriter(filestream, Encoding.Unicode); //serialize using the XmlTextWriter
                Serializer.Serialize(Writer, VoidMain.List.Employees);
                Writer.Close();
                Console.WriteLine("File is accessible via path: \"" + Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "hehe.xml\""));
            }
            private static void Main(string[] args)
            {
                VoidMain.List.Employees.Add(new Salaried { Name = "Kesha", Surname = "Ryabuhin", Post = "Janitor", Wage = 2281337.1488, });
                VoidMain.List.Employees.Add(new Waged { Name = "Artem", Surname = "Kalmyk", Post = "that guy from IT", Wage = 1337.7 });
                VoidMain.List.Employees.Add(new Waged { Name = "Keksik", Surname = "Ekler", Post = "SEO NA'VI", Wage = 228.8 });
                while (true)
                {
                    var i = Console.Read();
                    if (i == '1')
                    {
                        SerializeObject();
                    }
                    else if (i == '2')
                    {
                        Console.WriteLine("Pidor");
                    }

                }
            }
        }
    }
}


 /* using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Text;

namespace lab1
{
    [XmlInclude(typeof(Waged))]
    [XmlInclude(typeof(Salaried))]
    public abstract class OrganisationBC //abstract means that it's just a base class, it can contain abstract methods
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Post { get; set; }
        public double Wage { get; set; }
        public static double Payment (bool type, double stake, out double summary, out refrtotal)
        {
             if (type == false)
             {
                 summary=20.8*8*stake;
                 //rfrtotal=
             }
             else
             {
                 summary=stake;
             }
        }
        public class Waged : OrganisationBC //derived from abstract class organisationbc
        {

        }
        public class Salaried : OrganisationBC
        {

        }
        public class EmployeesList
        {
            public List<OrganisationBC> Employees { get; } = new List<OrganisationBC>();
        }
        internal class VoidMain
        {
            private static EmployeesList List = new EmployeesList();
            private static void SerializeObject()
            {
                XmlSerializer Serializer = new XmlSerializer(typeof(List<OrganisationBC>)); //create an xmlserializer to serialize string int xml text
                Stream filestream = new FileStream(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "hehe.xml"), FileMode.Create); //open a filestream
                XmlWriter Writer = new XmlTextWriter(filestream, Encoding.Unicode); //serialize using the XmlTextWriter
                Serializer.Serialize(Writer, VoidMain.List.Employees);
                Writer.Close();
                Console.WriteLine("\nFile is accessible via path: \"" + Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "/hehe.xml\""));
            }
            private static int Main(string[] args)
            {
                VoidMain.List.Employees.Add(new Salaried { Name = "Kesha", Surname = "Ryabuhin", Post = "Janitor", Wage = 2281337.1488, });
                VoidMain.List.Employees.Add(new Waged { Name = "Artem", Surname = "Kalmyk", Post = "that guy from IT", Wage = 1337.7 });
                VoidMain.List.Employees.Add(new Waged { Name = "Keksik", Surname = "Ekler", Post = "SEO NA'VI", Wage = 228.8 });
                while (true)
                {
                    var i = Console.Read();
                    if (i == '1')
                    {
                        SerializeObject();
                    }
                    else if (i == '2')
                    {
                        Console.WriteLine("\nPidor");
                    }
                    else if (i == '3')
                    {
                        Console.WriteLine("\nGnida");
                    }
                    else if (i == '9')
                    {
                        return (0);
                    }

                }
            }
}
    }
}



       //public abstract string Print(); 
        //public override string ToString();
    }
          //a non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors

        //public override string ToString()
        // {
        //      return $"{FirstName} {LastName}, {GroupName}";
        //  }
 *         //public float Rate { get; set; }

        //public override string ToString()
        // {
        //   return $"{Degree} {FirstName} {LastName} ({Rate} ставки)";
        //}
 *             //Console.WriteLine("Writing With XmlTextWriter");
 *             //Console.WriteLine(Serializer.ToString());
            EmployeesList List = new EmployeesList(); //we create new list which contains all empoyees
            Console.WriteLine(string.Join("\n", susu.Users));
            Stream filestream = new FileStream(filename, FileMode.Create);
            var StringSerialize = new XmlSerializer(typeof(List<OrganisationBC>));
            XmlWriter StringToXML = new XmlTextWriter(filestream, Encoding.Unicode);
            StringSerialize.Serialize(StringToXML, List.Employees); //perf

            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(writer.ToString());
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
            

            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "count.txt");
            using (var writerr = File.CreateText(backingFile))
            {
                writerr.WriteLineAsync(StringToXML.ToString());
            }
            

using System;

namespace lab1
{
public class OrganisationBC
{
public static void CalcPayments(char type, )
{

}
static string str;
static bool cout(string inc)
{
Console.WriteLine(inc);
return (true);
}
static string cin()
{
str = Console.ReadLine();
return (str);
}
static void Main(string[] args)
{
if (cout(cin()) == true)
{
    cout("if succeeded!");
}
} 
}
public class Fixed_rate :  OrganisationBC
{

}
public class Hourly_rate : OrganisationBC
{

}
}
*/
