using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace FightingDice
{

    public class ArmyList
    {
        public string Name { get; set; }
        public int WSBS { get; set; }
        public int Strength { get; set; }
        public int Toughness { get; set; }
        public int Armor { get; set; }
        public int Attacks { get; set; }
    }

    public class Validation
    {
        public bool isInt(string input)
        {
            int number = 0;
            return int.TryParse(input, out number);
        }
    }

   public class XMLTools
    {
        
        //Code to initialize new database -not used in finished project-
        public void WriteXML()
            {
                XDocument xmlDocument = new XDocument(
            
                new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("Fighting Dice army information storage"),

                    new XElement("ArmyLists",

                        new XElement("Army",
                            new XElement("Name", "Space Marines"),
                            new XElement("Strength", "4"),
                            new XElement("Toughness", "4"),
                            new XElement("WSBS", "3"),
                            new XElement("Armor", "4"),
                            new XElement("Attacks", "2"))
                ));

                xmlDocument.Save("Data.xml");
            }

        //Code to add new entry to xml
        //
        public void AppendXML(string name, string str, string tough, string wsbs, string armor, string atk)
        {
        
            XDocument xmlDocument = XDocument.Load("Data.xml");

            xmlDocument.Element("ArmyLists").Add(
                    new XElement("Army", new XAttribute("id", name),
                        new XElement("Name", name),
                        new XElement("Strength", str),
                        new XElement("Toughness", tough),
                        new XElement("WSBS", wsbs),
                        new XElement("Armor", armor),
                        new XElement("Attacks", atk)

                    ));

                xmlDocument.Save("Data.xml");
        }

        //code to delete an xml element
        public void DeleteXML(string name)
        {

            XDocument xmlDocument = XDocument.Load("Data.xml");

            xmlDocument.Root.Elements().Where(x => x.Attribute("id").Value == (string)name).FirstOrDefault().Remove();

            xmlDocument.Save("Data.xml");

        }

        //code to read xml file and enter its data into class.ArmyList
        public string[] readXML(string name)
        {
            
            string[] output = new string [6];



            IEnumerable<string> ArmyName = from army in XDocument.Load("Data.xml").Descendants("Army")
                                           where army.Attribute("id").Value == (string)name
                                           select army.Element("Name").Value;
            output[0] = ArmyName.FirstOrDefault();

            IEnumerable<string> ArmyStr = from army in XDocument.Load("Data.xml").Descendants("Army")
                                          where army.Attribute("id").Value == (string)name
                                          select army.Element("Strength").Value;
            output[1] = ArmyStr.FirstOrDefault();
                  
            IEnumerable<string> ArmyTough = from army in XDocument.Load("Data.xml").Descendants("Army")
                                            where army.Attribute("id").Value == (string)name
                                            select army.Element("Toughness").Value;
            output[2] = ArmyTough.FirstOrDefault();

            IEnumerable<string> ArmyWSBS = from army in XDocument.Load("Data.xml").Descendants("Army")
                                           where army.Attribute("id").Value == (string)name
                                           select army.Element("WSBS").Value;
            output[3] = ArmyWSBS.FirstOrDefault();

            IEnumerable<string> ArmyArmor = from army in XDocument.Load("Data.xml").Descendants("Army")
                                            where army.Attribute("id").Value == (string)name
                                            select army.Element("Armor").Value;
            output[4] = ArmyArmor.FirstOrDefault();
            
            IEnumerable<string> ArmyAtk = from army in XDocument.Load("Data.xml").Descendants("Army")
                                          where army.Attribute("id").Value == (string)name
                                          select army.Element("Attacks").Value;
            output[5] = ArmyAtk.FirstOrDefault();

            return output;
        }
    }

}
    
    
