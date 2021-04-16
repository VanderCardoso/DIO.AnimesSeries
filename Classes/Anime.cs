using System;

namespace DIO.AnimesSeries
{
    public class Anime : EntidadeBase
    {
        private Genero Genero {get; set;} 
        private string Titulo {get; set;}
        private string Sinopse {get; set;}
        private int AnoLancamento {get; set;} 
        private bool Excluido {get; set;}
        public Anime(int id, Genero genero, string titulo, string sinopse, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Sinopse = sinopse;
            this.AnoLancamento = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Sinopse: " + this.Sinopse + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.AnoLancamento + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        internal int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }

    
}