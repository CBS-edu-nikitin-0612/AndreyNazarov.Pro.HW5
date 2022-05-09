using System;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xDocument = null;
            try
            {
                xDocument = XDocument.Load(@"E:\Dropbox\dev\ITVDN\4 курс\HW5\Task6\bin\Debug\net5.0\TelephoneBook.xml");
                XElement root = xDocument.Root;

                var result = root.Elements().Select(i => i.Attribute("TelephoneNumber").Value);
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
