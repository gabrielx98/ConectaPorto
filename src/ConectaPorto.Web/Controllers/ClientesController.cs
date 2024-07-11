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

        public ClientesController(IClienteRepository clienteRepository, INotyfService notyfService)
        {
            _clienteRepository = clienteRepository;
            _notyfService = notyfService;
        }

        public async Task<IActionResult> Index()
        {
            var dados = (await _clienteRepository.ObterClientes()).Data;
            var lista = ListarViewModelExtension<Cliente>.Converter(dados);
            return View("Index", lista);
        }
        public Task<IActionResult> Exportar()
        {
            _notyfService.Custom("Exportado!!!", 10, "green", "fa fa-file-excel");
            return Index();
        }

        public Task<IActionResult> Editar(int id)
        {
            _notyfService.Custom("Editado!!!", 10, "blue", "fa fa-pencil");
            return Index();
        }

        public Task<IActionResult> Excluir(int id) {
            _notyfService.Custom("Excluido!!!", 10, "red", "fa-solid fa-trash");
            return Index();
        }
        
    }
}
