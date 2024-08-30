using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramacaoDoZero.Models
{
    public class Veiculo
    {
        //construtor
        public Veiculo()
        {
            TanqueCombustivel = 40;
        }

        //atributos ou propriedades
        public string Cor { get; set; }

        public string Marca { get; set; }

        public string Placa { get; set; }

        public string Modelo { get; set; }

        public int TanqueCombustivel { get; set; }

        //métodos
        public virtual void Acelerar()
        {
            InjetarCombustivel(1);
        }

        public void Frear()
        {

        }

        private void InjetarCombustivel(int quantidadeCombustivel)
        {
            TanqueCombustivel = TanqueCombustivel - quantidadeCombustivel;
        }
    }
}
