using CSharpModeloDDD.Domain.Entities;
using System;
using Inject;


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

            especial(cliente);

            //Console.WriteLine("Para ver os processos em execução, tecle ENTER");
            //Console.Read();

            //InjectPowershell.executaPowershellLocal();

            //Console.WriteLine("Para ver as credenciais em memória, tecle ENTER");
            //Console.Read();

            //InjectPowershell.obtemLogonPasswords();
            //Console.Read();

            //executaPowershellLocal();
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

       
    }

}
