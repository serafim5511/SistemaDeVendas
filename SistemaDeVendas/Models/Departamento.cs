﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaDeVendas.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();


        public Departamento()
        {

        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendas(DateTime inicio, DateTime final)
        {
            return Vendedores.Sum(vendedor => vendedor.TotalVendas(inicio, final));
        }
    }
}
