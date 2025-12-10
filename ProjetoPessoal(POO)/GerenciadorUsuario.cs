using System;
using System.Collections.Generic;

public class GerenciadorUsuario
{
    List<Usuario> bancoDados = new List<Usuario>(); //Inicializando a Lista/Banco dos Usuários. 

    private int proximoId = 1; //Inicializando o Contador para atribuir IDs únicos.


    public void CriarUsuario()
    {
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("--------------------CRIAR USUARIO----------------------------");
        Console.WriteLine("-------------------------------------------------------------");


        //Nome
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("Nome:");
        string nome = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("[ERRO] nome invalido");
            return;
        }

        //Email
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("Email:");
        string email = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(email))
        {
            Console.WriteLine("[ERRO] email invalido");
            return;
        }

        //Idade
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("Idade:");
        // Essa função de entrada de dados sempre trasforma em string
        if (!int.TryParse(Console.ReadLine(), out int idade)) // tudo que for diferente do dado tranformado em int manda um erro
        {
            Console.WriteLine("[ERRO] idade invalida");
            return;
        }

        //Senha
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("Senha:");
        string senha = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(senha) || senha.Length < 6)
        {
            Console.WriteLine("[ERRO] senha invalida");
            return;
        }
        Console.WriteLine("-------------------------------------------------------------");



        Usuario usuario = new Usuario(nome, email, idade, senha); //Concatena os dados para criar o novo Usuário.
        usuario.SetId(proximoId++); //Atribui um Id unico. Incrementando +1 sempre que criar um novo Usuário.

        bancoDados.Add(usuario); //Adicionou o novo usuário novo a minha Lista/Banco de Dados

        Console.WriteLine($"Usuario Criado com Sucesso");
    }

    public void ExibirUsuario()
    {
          
            foreach  (Usuario usuario in bancoDados)
            {
                if (usuario != null)
                {
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine($"Id do Usuario: {usuario.GetId()} ");
                    Console.WriteLine($"Nome: {usuario.GetNomeCompleto()} ");
                    Console.WriteLine($"Email: {usuario.GetEmail()}");
                    Console.WriteLine($"Idade: {usuario.GetIdade()}");
                    Console.WriteLine($"Senha: {usuario.GetSenha()}");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("-------------------------------------------------------------");
                }
                else 
                {
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("--------------Usuario Não Cadastrado-------------------------");
                Console.WriteLine("-------------------------------------------------------------");

            }


        }

    }

    public bool AtualizarUsuario() 
    {
        Usuario usuarioAtualizar = null; // inicializo ele como null pois se nao encontrar ele retorna como null.

        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("Digite o Id do Usuario:");
        if (int.TryParse(Console.ReadLine(), out int IdPesquisado)) // como o retorno e sempre em string é preciso tranformar em int para atribuir o valor digitado para o IdPesquisa


            foreach (Usuario usuarioPesquisado in bancoDados)  //Loop para buscar usuario pelo Id dentro da Lista(bancoDados)
            {
                if (IdPesquisado == usuarioPesquisado.GetId()) //Verifica se Id que o usuario digitou existe na Lista(bancoDados)
                {
                    usuarioAtualizar = usuarioPesquisado; //Pega usuario econtrado(usuarioPesquisado) e atribui na variavel que vai ser Atualizada(usuarioAtualizar)
                    break;
                }
            }


        if (usuarioAtualizar != null)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("----------------------ATUALIZE OS DADOS----------------------");
            Console.WriteLine("-------------------------------------------------------------");

            //Nome
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("");
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("[ERRO] nome invalido");
            }
            else
            {
                usuarioAtualizar.SetNomeCompleto(nome);
            }

            //Email
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Email:");
            string email = Console.ReadLine();
            Console.WriteLine("");
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("[ERRO] email invalido");
            }
            else
            {
                usuarioAtualizar.SetEmail(email);
            }

            //Idade
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Idade:");
            if (!int.TryParse(Console.ReadLine(), out int idade))
            {
                Console.WriteLine("[ERRO] idade invalida");
            }
            else
            {
                usuarioAtualizar.SetIdade(idade);
            }
            Console.WriteLine("-------------------------------------------------------------");


            //Senha
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Senha:");
            string senha = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------");
            if (string.IsNullOrWhiteSpace(senha) || senha.Length < 6)
            {
                Console.WriteLine("[ERRO] senha invalida");
            }
            else
            {
                usuarioAtualizar.SetSenha(senha);
            }

            return true;
        }
        else
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("----------------Id do Usuário não encontrado!----------------");
            Console.WriteLine("-------------------------------------------------------------");

            return false;
        }
    }

    public bool DeletarUsuario()
    {
        Usuario usuarioDeletar = null;
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("--------Digite o Id do usuário que deseja Deletar:-----------");
        Console.WriteLine("-------------------------------------------------------------");
        if (int.TryParse(Console.ReadLine(), out int IdPesquisado))
        {
            foreach (Usuario usuarioPesquisado in bancoDados) //Loop para buscar usuario pelo Id dentro da Lista(bancoDados)
            {
                if (IdPesquisado == usuarioPesquisado.GetId()) //Verifica se Id que o usuario digitou existe na Lista(bancoDados)
                {
                    usuarioDeletar = usuarioPesquisado; //Pega usuario econtrado(usuarioPesquisado) e atribui na variavel que vai ser Deletada(usuarioDeletar)
                }
            }
        }
        if (usuarioDeletar != null) //Verifica se ecnontrou algum objeto dentro da lista
        {
            bancoDados.Remove(usuarioDeletar);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"Usuario {usuarioDeletar.GetNomeCompleto()}Deletado com sucesso");
            Console.WriteLine("-------------------------------------------------------------");

            return true;
        }
        else
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"-------------Id do Usuario não encontrado.------------------");
            Console.WriteLine("-------------------------------------------------------------");

            return false;

        }

    }

    public void ExibirMenu()
    {

        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("1. Criar Usuário: ");
        Console.WriteLine("2. Atualizar Usuário: ");
        Console.WriteLine("3. Exibir Usuário: ");
        Console.WriteLine("4. Deletar Usuário: ");
        Console.WriteLine("5. SAIR");
        Console.WriteLine("-------------------------------------------------------------");

    }
}
