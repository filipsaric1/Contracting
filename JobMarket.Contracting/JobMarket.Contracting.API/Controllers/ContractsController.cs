using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    class ContractsController : ControllerBase
    {
        public ContractRepository _contractRepository { get; set; }

    }
}
