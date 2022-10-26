using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings {
    class Program {
        static void Main(string[] args) {
            string exempleString = string.Empty;
            exempleString = "Привет Сергей";
            int length = exempleString.Length;
            bool isContains = exempleString.Contains('Р');
            isContains = exempleString.Contains("При");
            int index = exempleString.IndexOf('р');
            index = exempleString.IndexOf('i');
            exempleString = exempleString.Insert(7, "Иванов ");
            index = exempleString.LastIndexOf('р');
            exempleString = exempleString.Remove(6,1);
            exempleString = exempleString.Remove(7);
            exempleString = exempleString.Replace("И", " Иванов Сергей");
            exempleString = exempleString.Replace("р", "Р");
            var arryStrings = exempleString.Split(' ');
            exempleString = exempleString.Substring(7, 5);
            var aryyChars = exempleString.ToCharArray();
            exempleString = string.Join("", aryyChars);
            exempleString = exempleString.ToLower();
            exempleString = exempleString.ToUpper();
            exempleString = "\t\tСтрока\t\t";
            exempleString = exempleString.TrimStart('\t');
            exempleString = exempleString.TrimEnd('\t');
            exempleString = exempleString.Trim('С', 'а');
            exempleString = index.ToString();

        }
    }
}
