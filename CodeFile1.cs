﻿public class Estudante {
  
    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }

    public Estudante(string nome) {
        Nome = nome;
    }

    public double Media {
        get {
            return (Nota1 + Nota2) / 2;
        }
    }
    public string Situacao {
        get { return Media >= 6.0 ? "Aprovado" : "Reprovado"; }
    }

    public void ExibirInformacoes() {

        Console.WriteLine($"Estudante: {Nome}");
        Console.WriteLine($"Média: {Media}");
        Console.WriteLine($"Situação: {Situacao} ");
    }

}