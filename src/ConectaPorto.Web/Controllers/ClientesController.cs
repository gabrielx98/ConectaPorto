using AspNetCoreHero.ToastNotification.Abstractions;
using ConectaPorto.Models;
using ConectaPorto.Web.Repository.Interface;
using ConectaPorto.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using ConectaPorto.Web.Extensions;

namespace ConectaPorto.Web.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly INotyfService _notyfService;
        /*
         * refazer modal editar para pagina
        exportar - checkbox
        cadastro
        criar botão para habilitar/desabilitar coluna id na tabela e no filtro
        ordenar
         */
        public ClientesController(IClienteRepository clienteRepository, INotyfService notyfService)
        {
            _clienteRepository = clienteRepository;
            _notyfService = notyfService;
        }

        public async Task<IActionResult> Index(int pagina = 1, int qtdItens = 4,string colunaFiltro = null,string valorFiltro = null)
        {
            var dados = (await _clienteRepository.ObterClientes());
            
            if (dados.HasErrors)
            {
                //_notyfService.Error(dados.Errors.Values.First(), 10);
                //_notyfService.Error(dados.ValidationProblemDetails.Errors.First().Value.First(), 10);
                return RedirectToAction("Index","Home");
            }

            return View("Index", new ClienteViewModel().Paginar(dados.Data, pagina, qtdItens, colunaFiltro, valorFiltro));
        }

        [HttpPost]
        public Task<IActionResult> Filtrar(ClienteViewModel view)
        {
            if(view.ColunaFiltro == null)
            {
                _notyfService.Error("Selecione uma coluna para filtrar", 10);
            }
            else if (view.ValorFiltro == null)
            {
                _notyfService.Error("Insira um valor para filtrar", 10);
            }
            return Index(colunaFiltro: view.ColunaFiltro, valorFiltro: view.ValorFiltro );
        }

        public Task<IActionResult> Exportar()
        {
            _notyfService.Custom("Exportado!!!", 10, "green", "fa fa-file-excel");
            return Index();
        }
        public async Task<IActionResult> Cadastrar(Cliente cliente)
        {
            //criar view cadastrar
            var dados = (await _clienteRepository.CadastrarCliente(cliente)).Data;
            _notyfService.Custom($"{dados.Nome} Cadastrado!!!", 10, "blue", "fa fa-pencil");
            return await Index();
        }
        public async Task<IActionResult> Editar()
        {
            return View();
        }

        public async Task<IActionResult> Editar(Cliente cliente)
        {
            var response = (await _clienteRepository.AtualizarCliente(cliente));
            if (response.HasErrors) {
                foreach(var errors in response.ValidationProblemDetails.Errors)
                {
                    foreach(var error in errors.Value)
                    {
                        _notyfService.Error($"{errors.Key} : {error}", 10);
                    }
                }
            }
            else
            {
               _notyfService.Custom($"Editado!!!", 10, "blue", "fa fa-pencil");
            }
            return await Index();
        }

        public async Task<IActionResult> Excluir(int id) {
            var dados = (await _clienteRepository.RemoverCliente(id)).Data;
            _notyfService.Custom($"{dados.Nome} Excluido!!!", 10, "red", "fa-solid fa-trash");
            return await Index();
        }
        
    }
}
