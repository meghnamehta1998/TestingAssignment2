using System;
using System.Text;

namespace StringOperations
{
    public static class Operations
    {
        public static string ConvertUpperLower(string x) {
            string y = "";
            for(int i = 0; i < x.Length; i++)
            {
                char ch = x[i];
                if (ch >= 'A' && ch <= 'Z') {
                    int p = (int)ch;
                    p = p + 32;
                    y += (char)p;
                }
                else if(ch>='a' && ch<='z')
                {
                    int q=(int)ch;
                    q = q - 32;
                    y += (char)q;
                }
                else
                {
                    y += ch;
                }
            }
            return y;
        }
    }
}
