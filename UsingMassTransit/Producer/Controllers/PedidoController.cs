using Core;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace Producer.Controllers
{
    [ApiController]
    [Route("/Pedido")]
    public class PedidoController : Controller
    {
        private readonly IBus _bus;
        private readonly IConfiguration _configuration;

        public PedidoController(IBus bus, IConfiguration configuration)
        {
            _bus = bus;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            //configurando a conexao

            var nomeFila = _configuration.GetSection("MassTransit")["NomeFila"] ?? string.Empty;
            var endPoint = await _bus.GetSendEndpoint(new Uri($"queues:{nomeFila}"));

            //enviando a mensagem
            await endPoint.Send(new Pedido(1, new Usuario(1, "Mauro", "mauro@email.com"), DateTime.Now));

            return Ok();
        }
    }
}
