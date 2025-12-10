using System;

public class Usuario
{
    private int Id { get; set; }
    private string NomeCompleto { get; set; }
    private string Email { get; set; }
    private int Idade { get; set; }
    private string Senha { get; set; }

    //Construtor
    public Usuario(string nome, string email, int idade, string senha)
    {
        this.NomeCompleto = nome;
        this.Email = email;
        this.Idade = idade;
        this.Senha = senha;
    }

    //Metodo de acesso: Identificador
    public int GetId() => this.Id;
    public void SetId(int novoId) => this.Id = novoId;

    //Metodos de acesso: Nome
    public string GetNomeCompleto() => this.NomeCompleto;
    public void SetNomeCompleto(string novoNomeCompleto) => this.NomeCompleto = novoNomeCompleto;

    //Metodos de acesso: Email
    public string GetEmail() => this.Email;
    public void SetEmail(string novoEmail) => this.Email = novoEmail;

    //Metodos de acesso: Idade
    public int GetIdade() => this.Idade;
    public void SetIdade(int novaIdade) => this.Idade = novaIdade;

    //Metodos de acesso: Senha
    public string GetSenha() => this.Senha;
    public void SetSenha(string novaSenha) => this.Senha = novaSenha;
}


