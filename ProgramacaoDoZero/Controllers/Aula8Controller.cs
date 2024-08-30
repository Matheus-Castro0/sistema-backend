using Microsoft.AspNetCore.Mvc;

namespace ProgramacaoDoZero.Controllers
{
    [Route("api/aula8")]
    [ApiController]
    public class Aula8Controller : ControllerBase
    {
        [Route("olaMundo")]
        [HttpGet]
        public string olaMundo()
        {
            var mensagem = "Olá Mundo via API";

            return mensagem;
        }

        [Route ("olaMundoPersonalizado")]
        [HttpGet]
        public string OlaMundoPersonalizado(string nome)
        {
            var mensagem = "Olá Mundo via API " + nome;

            return mensagem;
        }

        [Route ("somar")]
        [HttpGet]
        public string Somar(int valor1, int valor2)
        {
            var soma = valor1 + valor2;

            var mensagem = "A soma é = " + soma;

            return mensagem;
        }

        [Route ("media")]
        [HttpGet]
        public string Media(decimal valor1, decimal valor2)
        {
            var soma = valor1 + valor2;

            var divisao = soma / 2;

            var mensagem = "A média dos valores informados = " + divisao;

            return mensagem;
        }

        [Route ("valorTerreno")]
        [HttpGet]
        public string valorTerreno(decimal largura, decimal comprimento, decimal valorM)
        {
            var area = largura * comprimento;

            var calculo = area * valorM;

            var mensagem = "O valor do terreno é R$" + calculo;

            return mensagem;
        }

        [Route ("troco")]
        [HttpGet]
        public string troco(decimal valorProduto, int quantidadeProduto, decimal dinheiroEntregue)
        {
            var valorTotal = valorProduto * quantidadeProduto;

            var troco = dinheiroEntregue - valorTotal;

            var mensagem = "O valor do troco a ser entregue = " + troco;

            return mensagem;
        }

        [Route ("salario")]
        [HttpGet]
        public string salario(string nomeFuncionario, decimal valorHora, int horasTrabalhadas)
        {
            var valorAReceber = valorHora * horasTrabalhadas;

            var mensagem = nomeFuncionario + " deve receber R$" + valorAReceber + ", pois trabalhou por " + horasTrabalhadas + " horas no mês.";

            return mensagem;
        }

        [Route ("consumo")]
        [HttpGet]
        public string consumo(decimal distanciaPercorrida, decimal litrosGastos)
        {
            var consumo = distanciaPercorrida / litrosGastos;

            var mensagem = "Seu veículo tem um consumo médio de " + consumo + " Km/L";

            return mensagem;
        }
    }
}
