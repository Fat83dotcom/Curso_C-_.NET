using System;

namespace App3
{
    internal class MyConverter(string s)
    {
        private readonly string str = s;

        public int ConvertInt()
        {
            try
            {
                int value = Convert.ToInt32(str);
                return value;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public float ConvertFloat()
        {
            float value = Convert.ToSingle(str);
            return value;
        }
    }
}
