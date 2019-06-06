using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LiveTestQuestion01
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            List<string> codes = new List<string>();
            codes.Add("a 100100");
            codes.Add("b 100101");
            codes.Add("c 110001");
            codes.Add("d 100000");
            codes.Add("[newline] 111111");

            string encoded = "100100111111100101110001100000";

            //codes.Add("a seany");
            //codes.Add("b bob");
            //codes.Add("[newline] tim");

            //string encoded = "seanybobtim";

            var b = decode(codes, encoded);

        }

        public static string decode(List<string> codes, string encoded)
        {
            var result = String.Empty;
            List<string[]> splitList = new List<string[]>();

            for (int x = 0; x < codes.Count; x++)
            {
                var splitRow = codes[x].Split();
                splitList.Add(splitRow);
            }

            StringBuilder sb = new StringBuilder();

            string decode = encoded;


            while (decode.Length > 0)
            {
                foreach (var row in splitList)
                {
                    var part = decode.Substring(0, row[1].Length - 1);
                    if (decode.Substring(0, part.Length) == part)
                    {
                        var start = part.Length;
                        var endIt = decode.Length - start;

                        var newDecode = decode.Substring(start, endIt);
                        decode = newDecode;

                        var newChar = row[0];
                        if (newChar == "[newline]")
                        {
                            newChar = "\n";
                        }

                        sb.Append(newChar);
                    }
                }
            }

            result = sb.ToString();
            return result;

        }
    }
}
