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
         filtro
        exportar - checkbox
        cadastro
         */
        public ClientesController(IClienteRepository clienteRepository, INotyfService notyfService)
        {
            _clienteRepository = clienteRepository;
            _notyfService = notyfService;
        }

        public async Task<IActionResult> Index(int pagina = 1, int qtdItens = 4,string filtroCampo = null,string filtroValor = null)
        {
            var dados = (await _clienteRepository.ObterClientes());
            
            if (dados.HasErrors)
            {
                _notyfService.Error(dados.Errors.Values.First(), 10);
                return RedirectToAction("Index","Home");
            }

            return View("Index", new PaginacaoExtension<Cliente>().Paginar(dados.Data, pagina, qtdItens, filtroCampo, filtroValor));
        }
        public Task<IActionResult> Filtrar(string filtroCampo, string filtroValor)
        {
            return Index();
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

        public async Task<IActionResult> Editar(Cliente cliente)
        {
            var response = (await _clienteRepository.AtualizarCliente(cliente));
            _notyfService.Custom($"Editado!!!", 10, "blue", "fa fa-pencil");
            return await Index();
        }

        public async Task<IActionResult> Excluir(int id) {
            var dados = (await _clienteRepository.RemoverCliente(id)).Data;
            _notyfService.Custom($"{dados.Nome} Excluido!!!", 10, "red", "fa-solid fa-trash");
            return await Index();
        }
        
    }
}
