
using System;

// Select the entire code using Ctrl + A, then press Ctrl + K and Ctrl + F to format the code.

namespace VisualStudioTips
{
    public class FormattingCode
    {
        // Ugly comment...
        // This is a multi-line comment that's poorly formatted.
        // This is the second line...
        //// And the third line.

        public void Start()
        {
            var x = 1;
            var y = 2;

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine();
            }
            x.ToString();


        }
    }
    public class MyClass
    {
        private int myVar;
        public int MyProperty1 { get; set; }
        public MyClass _myClass { get; set; }
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }
}
