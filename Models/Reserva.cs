using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio__hospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int capacidade = Suite.Capacidade;
            if (hospedes.Count <= capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hospedes execedeu a capacidade");
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Capacity;
        }

        public decimal CalcularValorDiaria()
        {
            //TODO

            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = valor * 0.90M;
            }

            return valor;

        }
    }
}