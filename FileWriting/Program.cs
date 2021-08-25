using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FileWriting
{
    class Program
    {
        static void Main(string[] args)
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

            var s10 = "$$$$$$$";
            var s11 = "-------";
            var s12 = "@@@@@@@@@@@";
            var s13 = "&&&&&&&&&&";

            u3.StringBuilder.Append(s10);
            u3.StringBuilder.Append(s11);
            u3.StringBuilder.Append(s12);
            u3.StringBuilder.Append(s13);
            u3.StringBuilder.Append(Environment.NewLine);
            List<WritingUnit> list = new List<WritingUnit> { u1, u2, u3 };

            FileWriter fileWriter = new FileWriter("Text.txt");

            Parallel.ForEach(
                list,
                (unit) =>
                {
                    fileWriter.Write(unit);
                });
        }
    }
}
