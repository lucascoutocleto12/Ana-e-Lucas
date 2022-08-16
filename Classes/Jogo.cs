using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPR___Ana_e_Lucas.Classes
{
    internal class Jogo
    {

        //Atributos
        private String titulo; // Nome do Jogo
        private int data; // Data de lançamento do Jogo
        private String genero; // Gênero do Jogo
        private int maxJogadores; // Máximo de Jogadores
        private int metacritic; // Pontuação

        //Construtores
        public Jogo (String titulo, int data, String genero, int maxJogadores, int metacritic )
        {
            this.titulo = titulo;
            this.data = data;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
            this.metacritic = metacritic;
        }
        public Jogo(String titulo, int data, String genero, int maxJogadores)
        {
            this.titulo = titulo;
            this.data = data;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
        }

        // Metodos de Acesso
        public String getTitulo ()
        {
            return this.titulo;
        }
        public void setTitulo(String titulo)
        {
            if(titulo != "")
            {
                this.titulo = titulo;
            }
        }
        public String getGenero()
        {
            return this.genero;
        }
        public void setGenero(String genero)
        {
            if (genero != "")
            {
                this.genero = genero;
            }
        }
        public int getData()
        {
            return this.data;
        }
        public void setData(int data)
        {
            if (data > 1950)
            {
                this.data = data;
            }
        }
        public int getMaxJogadores()
        {
            return this.maxJogadores;
        }
        public void setMaxJogadores(int maxJogadores)
        {
            if (maxJogadores >= 1)
            {
                this.maxJogadores = maxJogadores;
            }
        }
        public int getMetacritic()
        {
            return this.metacritic;
        }
        public void setMetacritic(int metacritic)
        {
            if (metacritic >= 0 && metacritic <= 100 )
            {
                this.metacritic = metacritic;
            }
        }



    }
}
