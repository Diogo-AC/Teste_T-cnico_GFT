using System;
using System.Collections.Generic;

namespace Exercício_GTF_3
{
    class Program
    {
        static void Main(string[] args)
        {

        public class Agenda {

    private List<Contato> contatos = new ArrayList<>();

    public List<Contato> getContatos() {
        return contatos;
    }

    public void inserir(Contato contato) {
        contatos.Add(contato);
    }

    public void remover(Contato contato) {
        contatos.Remove(contato);
    }

    public void atualizar(Contato contato, Contato novoContato) {
        for (Contato cont : contatos) {
            if (cont.equals(contato)) {
                cont.setIdade(novoContato.getIdade());
                cont.setNome(novoContato.getNome());
                cont.setNumero(novoContato.getNumero());
            }
        }

    }

}

public class Contato {
    
    private String nome;
    private int numero;
    private int idade;

            public object Objects { get; private set; }

            public Contato(String nome, int numero, int idade) {
        this.nome = nome;
        this.numero = numero;
        this.idade = idade;
    }

 

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    @Override
    public String toString() {
        return "Contato{" + "nome=" + nome + ", numero=" + numero + ", idade=" + idade + '}';
    }

    @Override
    public int hashCode() {
        int hash = 7;
        hash = 41 * hash + Objects.GetHashCode(this.nome);
        hash = 41 * hash + this.numero;
        hash = 41 * hash + this.idade;
        return hash;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final Contato other = (Contato) obj;
        if (this.numero != other.numero) {
            return false;
        }
        if (this.idade != other.idade) {
            return false;
        }
        return Objects.equals(this.nome, other.nome);
    }
    
}
public class NewClass {

    public static void main(String[] args) {
        Contato con1 = new Contato("Pessoa1", 998785455, 24);
        Contato con2 = new Contato("Pessoa2", 998785455, 24);
        Contato con3 = new Contato("Pessoa3", 998785455, 24);
        Contato con4 = new Contato("Pessoa2", 456546546, 26);

        Agenda agenda = new Agenda();

        agenda.inserir(con1);
        agenda.inserir(con2);
        agenda.inserir(con3);

       Console.WriteLine("\n------> Antes de atualizar !! <------");
        for (int i = 0; i < agenda.getContatos().size(); i++) {
           Console.WriteLine(agenda.getContatos().get(i));

        }

        agenda.remover(con3);

       Console.WriteLine("\n------> Remover Contato 3 !! <------");
        for (int i = 0; i < agenda.getContatos().size(); i++) {
           Console.WriteLine(agenda.getContatos().GetType(i));

        }
        
        
        agenda.atualizar(con2,con4);

       Console.WriteLine("\n------> Atualizado contato 2 !! <------");
        for (int i = 0; i < agenda.getContatos().size(); i++) {
           Console.WriteLine(agenda.getContatos().GetType(i));

        }

        }
    }
}
