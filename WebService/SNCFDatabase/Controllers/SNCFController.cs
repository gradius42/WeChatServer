using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SNCFDatabase.Data;
using SNCFDatabase.Models;

namespace SNCFDatabase.Controllers
{
    [Produces("application/json")]
    [Route("api/SNCF")]
    public class SNCFController : Controller
    {
        [HttpGet("{name}")]
        public IEnumerable<MyStationContent> GetTrainStations([FromRoute] string name)
        {
            return SncfRequestTrainInfos.getTrainLineId(name).AsEnumerable();
        }
        
    }
}
