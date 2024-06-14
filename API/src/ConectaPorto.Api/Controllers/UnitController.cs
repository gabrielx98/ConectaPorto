using ConectaPorto.Dto;
using ConectaPorto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConectaPorto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        [HttpGet]
        [ApiExplorerSettings(GroupName = "Administrador")]
        public Unit Get()
        {
            return new Unit
            {
                Id = 1,
                Nbr = "",
                Proprietario = "",
                Iso = "",
                Categoria = "",
                TransitState = "",
                Transportadora = "",
                Booking = "",
                FreightKind = "",
                CarrierIb = "",
                CarrierOb = "",
                UsuarioAlteracao = "",
                UsuarioCriacao = "",
                DataAlteracao = "",
                DataCriacao = ""

            };
        }
    }
}
