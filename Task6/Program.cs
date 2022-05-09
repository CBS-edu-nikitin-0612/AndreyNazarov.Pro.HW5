using System;
using System.Xml;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "TelephoneBook.xml";
            XmlTextWriter writer = null;
            try
            {
                writer = new(file, System.Text.Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 2;
                writer.WriteStartDocument();
                writer.WriteStartElement("MyContacts");

                writer.WriteStartElement("Contact");
                writer.WriteStartAttribute("TelephoneNumber");
                writer.WriteString("12232");
                writer.WriteEndAttribute();
                writer.WriteString("Вася");
                writer.WriteEndElement();

                writer.WriteStartElement("Contact");
                writer.WriteStartAttribute("TelephoneNumber");
                writer.WriteString("234234");
                writer.WriteEndAttribute();
                writer.WriteString("Женя");
                writer.WriteEndElement();

                writer.WriteStartElement("Contact");
                writer.WriteStartAttribute("TelephoneNumber");
                writer.WriteString("2343242234");
                writer.WriteEndAttribute();
                writer.WriteString("Коля");
                writer.WriteEndElement();

                writer.WriteEndDocument();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (writer != null) writer.Close();
            }
        }
    }
}
