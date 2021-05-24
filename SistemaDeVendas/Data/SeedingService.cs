using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaDeVendas.Models;
using SistemaDeVendas.Models.Enums;

namespace SistemaDeVendas.Data
{
    public class SeedingService
    {
        private SistemaDeVendasContext _context;

        public SeedingService(SistemaDeVendasContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() || _context.Vendedor.Any() || _context.RegistroVenda.Any())
            {
                return; 
            }

            Departamento d1 = new Departamento(5,"TI");
            Departamento d2 = new Departamento(6, "Financeiro");
            Departamento d3 = new Departamento(8, "Comercial");
            Departamento d4 = new Departamento(10, "Marketing Digital");

            Vendedor v1 = new Vendedor(1, "Diego", "diego@gmail.com", new DateTime(2019, 4, 10), 3000.00, d1);
            Vendedor v2 = new Vendedor(2, "Maria", "maria@gmail.com", new DateTime(2000, 4, 21), 3000.00, d1);
            Vendedor v3 = new Vendedor(3, "Zé", "ze@gmail.com", new DateTime(1999, 4, 12), 3000.00, d1);
            Vendedor v4 = new Vendedor(4, "João", "joão@gmail.com", new DateTime(1996, 4, 18), 3000.00, d1);

            RegistroVendas r1 = new RegistroVendas(1, new DateTime(2015, 4, 10),12000.0, VendaStatus.Pendente, v1);
            RegistroVendas r2 = new RegistroVendas(2, new DateTime(2016, 4, 10), 12000.0, VendaStatus.Pendente, v4);
            RegistroVendas r3 = new RegistroVendas(3, new DateTime(2013, 4, 10), 12000.0, VendaStatus.Pendente, v2);
            RegistroVendas r4 = new RegistroVendas(4, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v1);
            RegistroVendas r5 = new RegistroVendas(5, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v1);
            RegistroVendas r6 = new RegistroVendas(6, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v1);
            RegistroVendas r7 = new RegistroVendas(7, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v2);
            RegistroVendas r8 = new RegistroVendas(8, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v2);
            RegistroVendas r9 = new RegistroVendas(9, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v2);
            RegistroVendas r10 = new RegistroVendas(10, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v2);
            RegistroVendas r11 = new RegistroVendas(11, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v3);
            RegistroVendas r12 = new RegistroVendas(12, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v1);
            RegistroVendas r13 = new RegistroVendas(13, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v1);
            RegistroVendas r14 = new RegistroVendas(14, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v3);
            RegistroVendas r15 = new RegistroVendas(15, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v3);
            RegistroVendas r16 = new RegistroVendas(16, new DateTime(2012, 8, 10), 3000.0, VendaStatus.Pendente, v3);
            RegistroVendas r17 = new RegistroVendas(17, new DateTime(2012, 8, 10), 2000.0, VendaStatus.Pendente, v3);
            RegistroVendas r18 = new RegistroVendas(18, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v2);
            RegistroVendas r19 = new RegistroVendas(19, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v2);
            RegistroVendas r20 = new RegistroVendas(20, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v2);
            RegistroVendas r21 = new RegistroVendas(21, new DateTime(2012, 8, 10), 12000.0, VendaStatus.Pendente, v2);


            _context.Departamento.AddRange(d1, d2, d3, d4);

            _context.Vendedor.AddRange(v1, v2, v3, v4);

            _context.RegistroVenda.AddRange(  
                
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21   
                
                );


            _context.SaveChanges();
        }
    }
}
