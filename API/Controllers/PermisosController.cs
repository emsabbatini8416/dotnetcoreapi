using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermisosController : ControllerBase
    {
        private readonly APIContext _context;

        public PermisosController(APIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Permiso>>> GetPermisos()
        {
            return await _context.Permisos.Include("TipoPermiso").ToListAsync();
        }
 
        [HttpPost]
        public async Task<ActionResult<Permiso>> PostPermiso([FromBody]Permiso permiso)
        {
            _context.Permisos.Add(permiso);
            await _context.SaveChangesAsync();

            return await _context.Permisos.Include("TipoPermiso").FirstAsync(x => x.Id == permiso.Id);
        }
    }
}
