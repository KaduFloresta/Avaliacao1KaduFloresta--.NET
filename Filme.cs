using System;

namespace NameFilme {

public class Filme {
    // Atributos
    public int idFilme;
    public String titulo;
    public String dataLanc;
    public String sinopse;
    public Double valorLoc;
    public int estoque;
    public int locado;

    // Construtor
    public Filme(int idFilme, String titulo, String dataLanc, String sinopse, Double valorLoc, int estoque) {
        this.idFilme = idFilme;
        this.titulo = titulo;
        this.dataLanc = dataLanc;
        this.sinopse = sinopse;
        this.valorLoc = valorLoc;
        this.estoque = estoque;
        this.locado = 0;
    }

    // Método com a Quantidade de locações Realizadas
    public void filmeLocado() {
        this.estoque -= 1;
        this.locado += 1;
    }

    // Impressão Dados do Filme
    public void mostrarFilme() {
        Console.WriteLine("----------------------------FILME----------------------------------------------------------------------------------------------------------");
        Console.WriteLine("--> Nº ID DO FILME: " + idFilme);
        Console.WriteLine("-> TÍTULO: " + titulo);
        Console.WriteLine("-> DATA DE LANÇAMENTO: " + dataLanc);
        Console.WriteLine("-> SINOPSE: " + sinopse);
        Console.WriteLine("-> VALOR DA LOCAÇÃO: R$ " + valorLoc);
        Console.WriteLine("-> QTDE EM ESTOQUE: " + estoque);
        Console.WriteLine("-> QTDE DE LOCAÇÕES REALIZADAS: " + locado);
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
    }
}
}