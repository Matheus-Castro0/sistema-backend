using Microsoft.AspNetCore.Mvc;
using ProgramacaoDoZero.Models;

namespace ProgramacaoDoZero.Controllers
{
    [Route("api/aula11")]
    [ApiController]
    public class Aula11Controller : ControllerBase
    {
        [Route("obterVeiculo")]
        [HttpGet]
        public Veiculo obterVeiculo()
        {
            var meuVeiculo = new Veiculo();

            meuVeiculo.Cor = "Azul";
            meuVeiculo.Marca = "Jeep";
            meuVeiculo.Modelo = "Renegade";
            meuVeiculo.Placa = "DEX-3358";

            meuVeiculo.Acelerar();

            return meuVeiculo;
        }

        [Route("obterCarro")]
        [HttpGet]
        public Carro obterCarro()
        {
            var meuCarro = new Carro();

            meuCarro.Cor = "Azul";
            meuCarro.Marca = "Honda";
            meuCarro.Modelo = "Fit";
            meuCarro.Placa = "DRT-2352";

            meuCarro.Acelerar();

            return meuCarro;
        }

        [Route("obterMoto")]
        [HttpGet]
        public Moto obterMoto()
        {
            var minhaMoto = new Moto();

            minhaMoto.Cor = "Azul";
            minhaMoto.Marca = "Yamaha";
            minhaMoto.Modelo = "Fazer 250";
            minhaMoto.Placa = "EED-3523";

            minhaMoto.Acelerar();

            return minhaMoto;
        }
    }
}
