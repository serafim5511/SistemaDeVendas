﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Services;

namespace SistemaDeVendas.Controllers
{
    public class RegistroVendasController : Controller
    {
        private readonly RegistroVendasService _registroVendasService;

        public RegistroVendasController(RegistroVendasService registroVendasService)
        {
            _registroVendasService = registroVendasService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BuscaSimples(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if(!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _registroVendasService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        public async Task<IActionResult> BuscaAgrupada(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _registroVendasService.FindByDateGroupAsync(minDate, maxDate);
            return View(result);
        }
    }
}