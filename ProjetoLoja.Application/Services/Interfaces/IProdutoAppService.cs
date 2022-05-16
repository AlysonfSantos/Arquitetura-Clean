﻿using ProjetoLoja.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoLoja.Application.Services.Interfaces
{
    public interface IProdutoAppService
    {
        Task<IEnumerable<ProdutoViewModel>> ListarProdutos();
    }
}