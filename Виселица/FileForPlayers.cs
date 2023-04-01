using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Виселица
{
    class FileForPlayers
    {
        public static void SerializeXML(List<Player> allPlayers)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Player>));
            FileStream fs = new FileStream("result.xml", FileMode.OpenOrCreate);
            xml.Serialize(fs, allPlayers);
            fs.Close();
        }
        public static List<Player> DeSerializeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Player>));
            FileStream fstr = new FileStream("result.xml", FileMode.Open);
            List<Player> players = (List<Player>)xml.Deserialize(fstr);
            fstr.Close();
            return players;
        }
    }
}