using SistemaDeVendas.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Quantidade { get; set; }
        public VendaStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }


        public RegistroVendas()
        {

        }

        public RegistroVendas(int id, DateTime data, double quantidade, VendaStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Status = status;
            Vendedor = vendedor;
        }

    }
}
