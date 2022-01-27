using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace _01_Generics
{
    public class Serializer
    {
        public static void Serialize(Object obj)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Gustavo\Documents\Arquivos c#\03_"+ obj.GetType().Name +".txt");

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();
            string objSerialize = jsSerialize.Serialize(obj);

            sw.Write(objSerialize);
            sw.Close();
        }

        public static T Deserialize<T>()
        {
            StreamReader stream = new StreamReader(@"C:\Users\Gustavo\Documents\Arquivos c#\03_" + typeof(T).Name+ ".txt");
            string path = stream.ReadToEnd();

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();
            T obj = (T) jsSerialize.Deserialize(path, typeof(T));

            return obj;
        }
    }
}
