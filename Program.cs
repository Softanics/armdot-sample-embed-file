using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armdot_sample_embed_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "somefile.txt")));
        }
    }
}
