using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_CONSOLE.Classes
{
    public static class FileWork
    {
        public static string ReadFile(string fileName)
        {
            var file = new StreamReader(fileName);
            string result = file.ReadToEnd();
            file.Close();
            return result;
        }
        public static void WriteFile (string fileName, string text)
        {
            var file = new StreamWriter(fileName);
            file.WriteLine(text);
            file.Close();
        }
    }
}
