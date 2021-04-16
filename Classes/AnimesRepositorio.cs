using System;
using System.Collections.Generic;
using DIO.AnimesSeries.Interfaces;

namespace DIO.AnimesSeries
{
    public class AnimesRepositorio : IRepositorio<Anime>
    {
        private List<Anime> listaAnime = new List<Anime>();
        public void Atualiza(int id, Anime entidade)
        {
            listaAnime[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaAnime[id].Excluir();
        }

        public void Insere(Anime objeto)
        {
            listaAnime.Add(objeto);
        }

        public List<Anime> Lista()
        {
            return listaAnime;
        }

        public int ProximoId()
        {
            return listaAnime.Count;
        }

        public Anime RetornaPorId(int id)
        {
            return listaAnime[id];
        }
    }
}