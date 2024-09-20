using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SistemaDeHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes {get; set;}
        public Suite Suite{get; set;}
        public int DiasReservados{get;set;}

        public Reserva(){}
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;
            
            if (valorTotal >= 10)
            {
                valorTotal -= valorTotal * 0.10m;
            }

            return valorTotal;
        }
    }
}