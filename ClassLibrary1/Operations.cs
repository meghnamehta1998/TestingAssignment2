using System;
using System.Text;

namespace StringOperations
{
    public static class Operations
    {
        public static string ConvertUpperLower(this string x)
        {
            string y = "";
            for (int i = 0; i < x.Length; i++)
            {
                char ch = x[i];
                if (ch >= 'A' && ch <= 'Z')
                {
                    int p = (int)ch;
                    p = p + 32;
                    y += (char)p;
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    int q = (int)ch;
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
        public static string CovertToTitleCase(this string x)
        {
            //"the CLEVER fox";
            string result = "";
            string[] words = x.Split(" ");
            int index = 0;
            string[] new_string = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                string w = words[i];
                Console.WriteLine(w);
                if (w[1] >= 'A' && w[1] <= 'Z')
                {
                    new_string[index] = w;
                    index++;
                }
                else
                {
                    string s = "";
                    int p = (int)w[0];
                    p = p - 32;
                    s += (char)p;
                    for (int k = 1; k < w.Length; k++)
                    {
                        s += w[k];
                    }
                    new_string[index] = s;
                    index++;
                }
            }
            for (int a = 0; a < index; a++)
            {
                if (a != 0)
                {
                    result = result + " " + new_string[a];
                }
                else
                {
                    result += new_string[a];
                }
            }
            return result;
        }
        public static bool CheckLower(this string x)
        {

            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                char ch = x[i];
                if (ch >= 'a' && ch <= 'z')
                {
                    count++;
                }
            }
            if (count == x.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string CovertToUpperCaseFirstCharater(this string x)
        {
            string s = "";
            int p = (int)x[0];
            p = p - 32;
            s += (char)p;
            for (int k = 1; k < x.Length; k++)
            {
                s += x[k];
            }
            return s;
        }
        public static bool CheckUpper(this string x)
        {

            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                char ch = x[i];
                if (ch >= 'A' && ch <= 'Z')
                {
                    count++;
                }
            }
            if (count == x.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckNumeric(this string x)
        {

            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                char ch = x[i];
                if (ch >= '0' && ch <= '9')
                {
                    count++;
                }
            }
            if (count == x.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string RemoveLastCharater(this string x)
        {
            string result = "";
            for (int i = 0; i < (x.Length - 1); i++)
            {
                result += (char)x[i];
            }
            return result;

        }
        public static int WordCount(this string x)
        {
            string[] words = x.Split(" ");
            return words.Length;
        }
        public static int ConvertStringToInt(this string x)
        {
            int number = int.Parse(x);
            return number;
        }
    }
}
