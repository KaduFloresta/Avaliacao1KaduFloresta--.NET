using System;
using NameLocacao;
using NameFilme;
using System.Collections.Generic;

namespace NameClienteLoc {

public class ClienteLoc {
	// Atributos
	public int idCliente;
	public String nome;
	public String dataNasc;
	public String cpf;
	public int diaDev;
	public int filmesLoc;
	public List<Locacao> locacoes = new List<Locacao>();

	// Construtor
	public ClienteLoc(int idCliente, String nome, String dataNasc, String cpf, int diaDev) {
		// Atributos
		this.idCliente = idCliente;
		this.nome = nome;
		this.dataNasc = dataNasc;
		this.cpf = cpf;
		this.diaDev = diaDev;
		this.filmesLoc = 0;
	}

	// Método com a Quantidade de Filmes locados
	public int QtdeFimesLocCliente(int filmesLoc) {
		return this.filmesLoc = filmesLoc;
	}

	// Impressão Dados do CLiente
	public void mostrarCliente() {
		Console.WriteLine($"----------------CLIENTE----------------");
		Console.WriteLine($"--> Nº ID DO CLIENTE: " + idCliente);
		Console.WriteLine($"-> NOME COMPLETO: " + nome);
		Console.WriteLine($"-> DATA DE NASCIMENTO: " + dataNasc);
		Console.WriteLine($"-> CPF: " + cpf);
		Console.WriteLine($"-> DIAS P/ DEVOLUÇÃO: " + diaDev);
		Console.WriteLine($"-> QTDE DE LOCAÇÕES: " + filmesLoc);
		Console.WriteLine($"----------------------------------------");
	}
	// Adição de Locações
	public void adicionarLocacao(Locacao locacao) {
		this.locacoes.Add(locacao);
	}

	// Lista de locações
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
