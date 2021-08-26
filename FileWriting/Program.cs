using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FileWriting
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamWriter streamWriter = new StreamWriter("Text.txt");
            var fileWriter = new FileWriter();
            var list = CreateData();

            Task[] tasks = new Task[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                tasks[i] = fileWriter.WriteAsync(list[i], streamWriter);
            }

            Task.WaitAll(tasks);
        }

        /// <summary>
        ///     создаёт массив объектов, внутри них только Stringbuilder
        /// </summary>
        /// <returns></returns>
        private static List<WritingUnit> CreateData()
        {
            var u1 = new WritingUnit();

            var s1 = "aaaaaaa";
            var s2 = "bbbbbb";
            var s3 = "cccccc";
            var s4 = "dddddd";
            var s5 = "eeeeeee";

            u1.StringBuilder.Append(s1);
            u1.StringBuilder.Append(s2);
            u1.StringBuilder.Append(s3);
            u1.StringBuilder.Append(s4);
            u1.StringBuilder.Append(s5);
            u1.StringBuilder.Append(Environment.NewLine);

            var u2 = new WritingUnit();

            var s6 = "11111111";
            var s7 = "22222222";
            var s8 = "33333333333";
            var s9 = "44444444";

            u2.StringBuilder.Append(s6);
            u2.StringBuilder.Append(s7);
            u2.StringBuilder.Append(s8);
            u2.StringBuilder.Append(s9);
            u2.StringBuilder.Append(Environment.NewLine);

            var u3 = new WritingUnit();

            var s10 = "$$$$$$$$$$$$$$$";
            var s11 = "-------";
            var s12 = "!!!!!!!!@@@";
            var s13 = "&&&&&&&&&&";

            u3.StringBuilder.Append(s10);
            u3.StringBuilder.Append(s11);
            u3.StringBuilder.Append(s12);
            u3.StringBuilder.Append(s13);
            u3.StringBuilder.Append(Environment.NewLine);

            return new List<WritingUnit> { u1, u2, u3 };
        }
    }
}
