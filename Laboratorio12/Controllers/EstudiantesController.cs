using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Laboratorio12.Models;

[Route("api/[controller]")]
[ApiController]
public class EstudiantesController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public EstudiantesController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Estudiante
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Estudiante>>> GetEstudiante()
    {
        return await _context.Estudiantes.ToListAsync();
    }

    // GET: api/Estudiante/5
    [HttpGet("{idestudiante}")]
    public async Task<ActionResult<Estudiante>> GetEstudiante(int idestudiante)
    {
        var estudiante = await _context.Estudiantes.FindAsync(idestudiante);

        if (estudiante == null)
        {
            return NotFound();
        }

        return estudiante;
    }

    // PUT: api/Estudiante/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{idestudiante}")]
    public async Task<IActionResult> PutEstudiante(int? idestudiante, Estudiante estudiante)
    {
        if (idestudiante != estudiante.IdEstudiante)
        {
            return BadRequest();
        }

        _context.Entry(estudiante).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!EstudianteExists(idestudiante))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Estudiante
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Estudiante>> PostEstudiante(Estudiante estudiante)
    {
        // El identificador es generado por SQL Server como columna IDENTITY.
        estudiante.IdEstudiante = 0;
        _context.Estudiantes.Add(estudiante);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetEstudiante", new { idestudiante = estudiante.IdEstudiante }, estudiante);
    }

    // DELETE: api/Estudiante/5
    [HttpDelete("{idestudiante}")]
    public async Task<IActionResult> DeleteEstudiante(int? idestudiante)
    {
        var estudiante = await _context.Estudiantes.FindAsync(idestudiante);
        if (estudiante == null)
        {
            return NotFound();
        }

        _context.Estudiantes.Remove(estudiante);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool EstudianteExists(int? idestudiante)
    {
        return _context.Estudiantes.Any(e => e.IdEstudiante == idestudiante);
    }
}
