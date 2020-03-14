using System;
using Filmes;
using Clientes;
using System.Collections.Generic;


namespace Locacaos {

public class Locacao {
	public int idLocacao = 0;
	public Cliente cliente;
	public String dataLocacao;
	public String dataDevolucao;
	public Double valorTotal;

	public List<Filme> filmes = new List<Filme>();

	public Locacao(int idLocacao, Cliente cliente) {

		this.idLocacao = idLocacao;
		this.cliente = cliente;

		this.cliente.adicionarLocacao(this);
	}
	public void AdicionarFilme(Filme filme) {
		this.filmes.Add(filme);
	}
	
	public double PrecoTotal() {
		double total = 0;
		foreach (Filme filme in filmes) {
			total += filme.valorLocacao;
		}
		return total;
	}
	public int QtdeFilmesLocados() {
		return this.filmes.Count;
	}

	public String calcularDataDevolucao() {
		DateTime dataAtual = DateTime.Now;

		return dataAtual.AddDays(cliente.diaDevolucao).ToString("dddd, dd MMMM yyyy");
	}
}
}