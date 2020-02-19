using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPermisosController : ControllerBase
    {
        private readonly APIContext _context;

        public TipoPermisosController(APIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoPermiso>>> GetTipoPermisos()
        {
            return await _context.TipoPermisos.ToListAsync();
        }
    }
}