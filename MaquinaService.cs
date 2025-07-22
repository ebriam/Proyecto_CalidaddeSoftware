using TragamonedasApp.Models;
using System.Collections.Generic;

namespace TragamonedasApp.Services
{
    public class MaquinaService
    {
        private List<Maquina> maquinas = new List<Maquina>();

        public void RegistrarMaquina(Maquina maquina)
        {
            maquinas.Add(maquina);
        }

        public List<Maquina> ObtenerMaquinas()
        {
            return maquinas;
        }
    }
}