using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    static class Json<T>
    {
        static public List<T> JsonToList(string path = @"klientai.json")
        {
            List<T> list = new List<T>();

            if (path != null)
            {
                    list = JsonConvert.DeserializeObject<List<T>>(ReadJsonFromFile(path));
            }
            return list;
        }

        static public string ReadJsonFromFile(string path)
        {
            string jsonString = "";

            if (path != null)
            {
                    jsonString = File.ReadAllText(path, Encoding.UTF8);
            }
            return jsonString;
        }

    }
}
