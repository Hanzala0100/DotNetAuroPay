using System.Text;

namespace FileIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\practiceDotNet\Day13\MyText.txt";
            //if (!File.Exists(path))
            //{
            //    using(StreamWriter sw = File.CreateText(path))
            //    {
            //        sw.WriteLine("Hello");
            //        sw.WriteLine("And");
            //        sw.WriteLine("World");
            //    }
            //    Console.WriteLine("done!");
            //}

            //using(StreamReader sr = File.OpenText(path))
            //{
            //    string s = "";
            //    while((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //FileInfo fi = new FileInfo(path);
            //if(!fi.Exists )
            //{
            //    using(StreamWriter sw = fi.CreateText())
            //    {
            //        sw.WriteLine("Hello");
            //        sw.WriteLine("And");
            //        sw.WriteLine("World");
            //    }
            //}

            //using (StreamReader sr = fi.OpenText())
            //{
            //    string s = "";
            //    while((s =  sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //try
            //{
            //    string path2 = Path.GetTempFileName();
            //    FileInfo fi2 = new FileInfo(path2);

            //    fi2.Delete();
            //    fi.CopyTo(path2);

            //    Console.WriteLine($"{path} was copied in {path2}");

            //    fi2.Delete();

            //    Console.WriteLine($"{path2} was sucessfully deleted");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("failed" + (ex.ToString()));
            //}

            try
            {
                using(FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("this is some text example");
                    fs.Write(info, 0, info.Length);
                }

                using(StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("failed" + (ex.ToString()));
            }
        }
    }
}
