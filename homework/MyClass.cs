using System;
using System.Text;

namespace homework
{
    internal class MyClass
    {
        public string MyProperty { get; set; } // why?

        public MyClass(string myProperty)
        {
            MyProperty = myProperty;
        }

        public void Space(string str)
        {
            var data = new StringBuilder();

            if (str is null) new ArgumentNullException(nameof(str));

            for (int i = 0; i < str.Length; i++)
            {
                data.Append(str[i]);
                if (i != str.Length - 1) data.Append('_');
            }

            MyProperty = data.ToString();
            Console.WriteLine(MyProperty);
        }
        public void Reverse(string str)
        {
            var data = new StringBuilder();

            if (str is null) new ArgumentNullException(nameof(str));

            for (int i = str.Length - 1; i >= 0; i--) data.Append(str[i]);

            MyProperty = data.ToString();
            Console.WriteLine(MyProperty);
        }
    }
}
