using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace appTsane {
    public class ClienteController: Controller{
        private readonly ILogger<ClienteController>_logger;
        public ClienteController(ILogger<ClienteController> logger)
            
        {
            _logger = logger;
         
        }
    }
}