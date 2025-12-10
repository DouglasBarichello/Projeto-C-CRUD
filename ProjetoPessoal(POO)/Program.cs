using System;
using System.Collections.Generic;
public class Program 
{
    
    static void Main(string[] args)
    {
        GerenciadorUsuario gerenciador = new GerenciadorUsuario();

        

        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1. Criar Usuário: ");
            Console.WriteLine("2. Atualizar Usuário: ");
            Console.WriteLine("3. Exibir Usuário: ");
            Console.WriteLine("4. Deletar Usuário: ");
            Console.WriteLine("5. SAIR");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("");


            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    gerenciador.CriarUsuario();
                    break;

                case "2":
                    gerenciador.AtualizarUsuario();
                    break;

                case "3":
                    gerenciador.ExibirUsuario();
                    break;

                case "4":
                    gerenciador.DeletarUsuario();
                    break;

                case "5":
                    Environment.Exit(0);
                    break;
            }
        }


    }

}

