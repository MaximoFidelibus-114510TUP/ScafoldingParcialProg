using _114510RecuperatorioScafolding.Services.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _114510RecuperatorioScafolding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParcialController : ControllerBase
    {
        private readonly IParcialService _parcialServices;

        public ParcialController(IParcialService parcialServices)
        {
            _parcialServices = parcialServices;
        }









    }
}
