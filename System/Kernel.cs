using AndroidSystemOS.System;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace AndroidSystemOS
{
    public class Kernel : Sys.Kernel
    {

        CMD cmd = new CMD();
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("--------Damn-------");
        }

        protected override void Run()
        {
            cmd.Start();
        }
    }
}
