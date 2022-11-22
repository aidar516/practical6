using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practical_6
{
    internal class SerialandDeserial
    {
        /*public static void JsonSerial(wwf wwfs, string put2)
        {
            string json = JsonConvert.SerializeObject(wwfs);
            File.WriteAllText(put2, json);
        }
        public static void XmlSerial(wwf wwfs, string put2)
        {
            XmlSerializer xml = new XmlSerializer(typeof(wwf));
            using (FileStream f = new FileStream(put2, FileMode.OpenOrCreate))
            {
                xml.Serialize(f, wwfs);
            }
        }
        public static void JsonDeserial(string put2)
        {
            string js = File.ReadAllText(put2);
            List<wwf> result = JsonConvert.DeserializeObject<List<wwf>>(js);
        }
        public static void XmlDeserial(string put2)
        {
            wwf tekst;
            XmlSerializer xml = new XmlSerializer(typeof(wwf));
            using (FileStream ff = new FileStream(put2, FileMode.Open))
            {
                tekst = (wwf)xml.Deserialize(ff);
            }
        }*/

    }
}

