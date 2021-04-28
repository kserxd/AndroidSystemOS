using System;
using System.Collections.Generic;
using System.Text;

namespace AndroidSystemOS.Commands
{
    class Exit
    {
        public Exit()
        {
            Cosmos.System.Power.Shutdown();
        }
    }
}
