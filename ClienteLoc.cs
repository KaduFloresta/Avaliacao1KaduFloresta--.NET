using System;
using Locacaos;
using Filmes;
using System.Collections.Generic;

namespace Clientes {

public class Cliente {

	public int idCliente;
	public String nome;
	public String dataNascimento;
	public String cpf;
	public int diaDevolucao;
	public int filmesLocacao;
	public List<Locacao> locacoes = new List<Locacao>();

	public Cliente(int idCliente, String nome, String dataNascimento, String cpf, int diaDevolucao) {
		
		this.idCliente = idCliente;
		this.nome = nome;
		this.dataNascimento = dataNascimento;
		this.cpf = cpf;
		this.diaDevolucao = diaDevolucao;
		this.filmesLocacao = 0;
	}

	public int atribuirFilmesLocados(int filmesLocacao) {
		return this.filmesLocacao = filmesLocacao;
	}

	public void mostrarCliente() {
		Console.WriteLine($"----------------CLIENTE----------------");
		Console.WriteLine($"--> Nº ID DO CLIENTE: " + idCliente);
		Console.WriteLine($"-> NOME COMPLETO: " + nome);
		Console.WriteLine($"-> DATA DE NASCIMENTO: " + dataNascimento);
		Console.WriteLine($"-> CPF: " + cpf);
		Console.WriteLine($"-> DIAS P/ DEVOLUÇÃO: " + diaDevolucao);
		Console.WriteLine($"-> QTDE DE LOCAÇÕES: " + filmesLocacao);
		Console.WriteLine($"----------------------------------------");
	}
	
	public void adicionarLocacao(Locacao locacao) {
		this.locacoes.Add(locacao);
	}

	public int getLocacoes() {
		int qtd = 0;

		foreach (Locacao locacao in this.locacoes) {
			foreach (Filme filme in locacao.filmes) {
				qtd++;
			}
		}

		return qtd;
	}
}
}
