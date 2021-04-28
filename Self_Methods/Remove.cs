using System;
using System.Collections.Generic;
using System.Text;

namespace AndroidSystemOS.Self_Methods
{
    class RemoveLst
    {
        public string RemoveLstString(string input)
        {
            string output = "";
            for (int i = 0; i < (input.Length - 1); i++)
            {
                output += input[i];
            }
            return output;
        }
    }
}
