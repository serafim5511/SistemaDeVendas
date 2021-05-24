using SistemaDeVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaDeVendas.Services
{
    public class DepartamentoService
    {
        private readonly SistemaDeVendasContext _context;

        public DepartamentoService(SistemaDeVendasContext context)
        {
            _context = context;
        }

        public async Task<List<Departamento>> FindAllAsync()
        {
            return await _context.Departamento.OrderBy(d => d.Nome).ToListAsync();
        }
    }
}
