using Newtonsoft.Json;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
namespace Practical_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            wwf figure1 = new wwf();
            figure1.Name = "Квадрат";
            figure1.Height = 100;
            figure1.Width = 100;
            wwf figure2 = new wwf();
            figure2.Name = "Прямоугольник";
            figure2.Height = 50;
            figure2.Width = 25;
            Console.WriteLine("Введите путь до файла, который вы хотите открыть");
            Console.WriteLine("------------------------------------------------");
            string put = Console.ReadLine();
            if (File.Exists(put))
            {
                Console.Clear();
                Console.WriteLine("Сохранить файл в одном из форматов(xml, json, txt) - F1.Закрыть программу - Escape.");

                string txt = File.ReadAllText(put);
                Console.WriteLine(txt);


                List<wwf> wwfs = new List<wwf>();
                wwfs.Add(figure1);
                wwfs.Add(figure2);

                ConsoleKeyInfo klav = Console.ReadKey();
                while (klav.Key != ConsoleKey.Escape)
                {
                    if (klav.Key == ConsoleKey.F1)
                    {
                        Console.Clear();
                        Console.WriteLine("Введите путь до файла (с названием) куда вы хотите его сохранить");
                        string path = Console.ReadLine();
                        if (File.Exists(path))
                        {
                            if (path.Contains("json"))
                            {
                                if (put.Contains("txt"))
                                {
                                    string json = JsonConvert.SerializeObject(wwfs);
                                    File.WriteAllText(path, json);
                                }
                                else
                                {
                                    string js = File.ReadAllText(path);
                                    List<wwf> result = JsonConvert.DeserializeObject<List<wwf>>(js);
                                }
                            }
                            else if (path.Contains("xml"))
                            {
                                if (put.Contains("txt"))
                                {
                                    XmlSerializer xml = new XmlSerializer(typeof(wwf));
                                    using (FileStream f = new FileStream(path, FileMode.OpenOrCreate))
                                    {
                                        xml.Serialize(f, wwfs);
                                    }
                                }
                                else
                                {
                                    wwf tekst;
                                    XmlSerializer xml = new XmlSerializer(typeof(wwf));
                                    using (FileStream ff = new FileStream(path, FileMode.Open))
                                    {
                                        tekst = (wwf)xml.Deserialize(ff);
                                    }
                                }
                            }
                        }
                        else
                        {
                            File.Create(path);
                        }
                    }
                    else if (klav.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                    klav = Console.ReadKey();
                }
            }
        }
    }
}