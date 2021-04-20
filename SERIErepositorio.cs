using System ;
using System.Collections.Generic;

namespace PROJECT_SERIES_CARLOS_.CLASSES
{
    public class SERIEREPOSITORIO
    {
        public class SerieRepositorio : IRepositorio<Serie>
        {
            private List <Serie> ListaSerie = new List<Serie>();
            public void Atualiza (int id, Serie objeto)
            {
                listaSerie[id]= objeto ;
            }
            public void Exclui(int id)
            {
                listaSerie[id].Excluir();
            }
            public void InserirSerie(Serie objeto)
        }
        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto)
        }
        public List<Serie> Lista()
        {
            return listaSerie;
        }
        public int ProximoId()
        {
            return listaSerie.Count;
        }
        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }



    }    
         
}