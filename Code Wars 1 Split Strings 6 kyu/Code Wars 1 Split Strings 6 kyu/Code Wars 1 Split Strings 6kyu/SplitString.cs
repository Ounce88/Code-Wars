using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars_1_Split_Strings_6_kyu
{
    public static class SplitString
    {

        public static string[] Solution(string str)
        {

            List<string> list = new List<string>();
            string saver = "";
            int count = 0;
            while(count < str.Length)
            {
                count += 2;
                if (count > str.Length)
                {
                     saver = str.Substring(count-2)[0].ToString() + "_";
                }
                else
                {
                    saver = str.Substring(count-2)[0].ToString() + str.Substring(count - 1)[0].ToString();
                }
                list.Add(saver);
            }



            return list.ToArray(); 
        }



    }
}
