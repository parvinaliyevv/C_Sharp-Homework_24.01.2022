using System;

namespace homework
{
    internal class Run
    {
        public void RunFunc(Program.Func MyDelegate, string str) => MyDelegate.Invoke(str);
    }
}
