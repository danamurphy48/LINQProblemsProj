using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Problem4
    {
        public string CompressStringAndNumber(string word)
        {
            int counter = 1;
            string compressedStr = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (i < word.Length - 1)
                {
                    if (word[i] == word[i + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        compressedStr += counter + word[i].ToString();
                        counter = 1;
                    }
                }
                else
                {
                    compressedStr += counter + word[i].ToString();
                }
            }
            return compressedStr;
        }

    }
}
