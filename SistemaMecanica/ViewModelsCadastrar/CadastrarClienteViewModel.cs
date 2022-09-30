﻿using SistemaMecanica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMecanica.ViewModels
{
    public class CadastrarClienteViewModel
    {
        public string IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string CpfCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public Veiculos veiculos { get; set; }
    }
}
