using EnvDTE80;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geeks.VSIX.SmartAttach.Attacher
{
    public static class ProcSession
    {
        public static List<ProcHolder> ValidProcesses = new List<ProcHolder>();
        public static List<Process2> InvalidProcesses = new List<Process2>();
    }
}
