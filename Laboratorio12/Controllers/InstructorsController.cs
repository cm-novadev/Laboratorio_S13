using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Laboratorio12.Models;

[Route("api/[controller]")]
[ApiController]
public class InstructorsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public InstructorsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Instructor
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Instructor>>> GetInstructor()
    {
        return await _context.Instructores.ToListAsync();
    }

    // GET: api/Instructor/5
    [HttpGet("{idinstructor}")]
    public async Task<ActionResult<Instructor>> GetInstructor(int idinstructor)
    {
        var instructor = await _context.Instructores.FindAsync(idinstructor);

        if (instructor == null)
        {
            return NotFound();
        }

        return instructor;
    }

    // PUT: api/Instructor/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{idinstructor}")]
    public async Task<IActionResult> PutInstructor(int? idinstructor, Instructor instructor)
    {
        if (idinstructor != instructor.IdInstructor)
        {
            return BadRequest();
        }

        _context.Entry(instructor).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!InstructorExists(idinstructor))
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

    // POST: api/Instructor
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Instructor>> PostInstructor(Instructor instructor)
    {
        // El identificador es generado por SQL Server como columna IDENTITY.
        instructor.IdInstructor = 0;
        _context.Instructores.Add(instructor);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetInstructor", new { idinstructor = instructor.IdInstructor }, instructor);
    }

    // DELETE: api/Instructor/5
    [HttpDelete("{idinstructor}")]
    public async Task<IActionResult> DeleteInstructor(int? idinstructor)
    {
        var instructor = await _context.Instructores.FindAsync(idinstructor);
        if (instructor == null)
        {
            return NotFound();
        }

        _context.Instructores.Remove(instructor);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool InstructorExists(int? idinstructor)
    {
        return _context.Instructores.Any(e => e.IdInstructor == idinstructor);
    }
}
