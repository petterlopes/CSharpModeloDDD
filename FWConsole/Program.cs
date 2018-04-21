using CSharpModeloDDD.Domain.Entities;
using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace FWConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Ativo = true;
            cliente.ClienteId = 0001;
            cliente.DataCadastro = DateTime.Now;
            cliente.Nome = "Iron Man";

            executaPowershellLocal();

            //executaPowershellRemoto();

            especial(cliente);
        }

        public static void especial(Cliente _cliente)
        {
            if (_cliente.ClienteEspecial(_cliente))
            {
                Console.WriteLine("Especial: " + _cliente.Nome);
                Console.WriteLine("Você tem acesso total a área restrita!!!");
                Console.ReadLine();
            }
            else
            {
                Console.Write(_cliente.Nome + " não é especial.");
                Console.ReadLine();
            }
        }

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
                    var processo = (System.Diagnostics.Process)result.BaseObject;
                    Console.WriteLine(string.Format("pid: {0, 10} \t {1} ", processo.Id, processo.ProcessName));
                    //processo.Kill();
                }
            }

            runspace.Close();
        }
    }
}
