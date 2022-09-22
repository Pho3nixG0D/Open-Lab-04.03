using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            string result;
            if (original.Length >= 3)
            {
                result = original.Substring(1, original.Length - 2);
                return result;
            } else if (original.Length >= 1 && original.Length <2) { 
                return original; ;
            }
            else
            {
                return "";
            }
            
        }
    }
}
