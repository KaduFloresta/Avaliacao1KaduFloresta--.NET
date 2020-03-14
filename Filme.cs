using System;

namespace Filmes {
    public class Filme {
        public int idFilme;
        public String titulo;
        public String dataLancamento;
        public String sinopse;
        public Double valorLocacao;
        public int qtdEstoque;
        public int qtdLocados;

        public Filme(int idFilme, String titulo, String dataLancamento, String sinopse, Double valorLocacao, int qtdEstoque) {
            this.idFilme = idFilme;
            this.titulo = titulo;
            this.dataLancamento = dataLancamento;
            this.sinopse = sinopse;
            this.valorLocacao = valorLocacao;
            this.qtdEstoque = qtdEstoque;
            this.qtdLocados = 0;
        }

        public void atualizarEstoque() {
            this.qtdEstoque -= 1;
            this.qtdLocados += 1;
        }

        public void mostrarFilme() {
            Console.WriteLine("----------------------------FILME----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--> Nº ID DO FILME: " + idFilme);
            Console.WriteLine("-> TÍTULO: " + titulo);
            Console.WriteLine("-> DATA DE LANÇAMENTO: " + dataLancamento);
            Console.WriteLine("-> SINOPSE: " + sinopse);
            Console.WriteLine("-> VALOR DA LOCAÇÃO: R$ " + valorLocacao);
            Console.WriteLine("-> QTDE EM ESTOQUE: " + qtdEstoque);
            Console.WriteLine("-> QTDE DE LOCAÇÕES REALIZADAS: " + qtdLocados);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}