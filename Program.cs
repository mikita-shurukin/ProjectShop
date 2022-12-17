using System;
using System.Text.Json;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace JSONSerializers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] d = File.ReadAllLines("path (input)");
            Console.WriteLine(d);

            var picture = new IPicture();

            for (int i = 0; i <= d.Length - 1; i++)
            {
                string id = d[i];
                var a = _download_serialized_json_data<IJSON>(id);

                Console.WriteLine($"{a.safe_title}");

                using (WebClient webClient = new WebClient())
                {
                    byte[] dataArr = webClient.DownloadData($"{a.img}");
                    File.WriteAllBytes("path (output)", dataArr);
                }
            }
        }

        public static T _download_serialized_json_data<T>(string id) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                try
                {
                    json_data = w.DownloadString($"");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
    }
}