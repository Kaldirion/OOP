using System;
using System.Collections.Generic;
using System.Text;


namespace Homework_06
{
    public static class Extensions
    {
        public static StringBuilder RemoveChar(this StringBuilder str,char ch)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    str.Remove(i,1);
                }
            }
            return str;
        }

        public static StringBuilder RemoveText(this StringBuilder str, string input)
        {
            char[] tempArr;
            tempArr = str.ToString().ToCharArray();
            int j = 0;
            int count = 0;
            StringBuilder result = new StringBuilder("");
            for (int i = 0; i < str.Length - input.Length; i++)
            {
                count = 0;
                j = 0;
                if (str[i] == input[j])
                {
                    for (j = 0; j < input.Length; j++)
                    {
                        if (str[i + j] == input[j])
                        {
                            count++;
                        }
                    }
                    if (count == input.Length)
                    {
                        result = str.Remove(i, input.Length);
                    }
                }
            }
            return result;
        }

        public static string Substring (this StringBuilder str, int startIndex, int length){
            if (startIndex < 0 || str.Length - length - startIndex < 0) {
                throw new ArgumentOutOfRangeException("index is out of range");
            }
            else {
                string result = "";
                char[] tempArr;
                tempArr = str.ToString().ToCharArray();
                for (int i = startIndex;i<startIndex + length;i++){
                    result = result + tempArr[i].ToString();
                }
                return result;
            }
        }

        public static string AppendAll<T>(this StringBuilder str,IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                str.Append(item);
            }
            return str.ToString();
        }
    }

}
