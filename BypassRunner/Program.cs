using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BypassRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if (args[0].Length > 0)
            {
                if (args[0].ToLower().Contains("win7"))
                {
                    Bypass.VMs.VMWare_7.WIN_7_Patch();
                }

                if (args[0].ToLower().Contains("win10"))
                {
                    Bypass.VMs.VMWare_10.WIN_10_Patch();
                }

                if (args[0].ToLower().Contains("unpatch7"))
                {
                    Bypass.VMs.VMWare_7.WIN_7_Unpatch();
                }
                if (args[0].ToLower().Contains("unpatch10"))
                {
                    Bypass.VMs.VMWare_10.WIN_10_Unpatch();
                }
            }
        }
    }
}
