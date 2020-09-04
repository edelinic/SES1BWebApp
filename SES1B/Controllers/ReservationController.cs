using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SES1B.Models;

namespace SES1B.Controllers
{
    [Route("api/Reservation")]
    [ApiController]

    public class ReservationController : ControllerBase
    {
      private readonly ReservationContext_context;

      public ReservationController(ReservationController context)
      {
        _context = context;
      }

      [HttpGet]
      public IEnumerable<Reserveation> GetReserveations()
      {
        return _Context.Reservation;
      }

      [HttpGet("{id}")]
      public async Task<IActionResult> GetReservation([FromRoute] int id)
      {
        if (!modelState.Isvalid)
        {
          return BadRequest(ModelState);
        }
      }

      [HttpPut("{id}")]
      public async Task<IActionResult> PutReservation([FromRoute] int id, [FromBody] Reservation reservation)
      {
        if (!modelState.Isvalid)
        {
          return BadRequest(ModelState);
        }

        if (id != game.id)
        {
          return BadRequest();
        }

        _context.Entry(game).State = EntityState.Modified;

        try
        {
          await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!GameExists(id))
          {
            return NotFount();
          }
          else
          {
            throw;
          }
        }

        return NoContent();
      }

      [HttpPost]
      public async Task<IActionResult> PostReservation([FromBody] Reservation reservation)
      {
        if (!ModelState.Isvalid)
        {
          return BadRequest(ModelState);
        }

        _context.Reservation.SaveChangesAsync();

        return CreatedAtAction("GetReservation", new { id = Game.Id}, game);
      }

      [HttpDelete("{id}")]
      public async Task<IActionResult> DeleteReservation([FromRoute] int id)
      {
        if (!ModelState.IsValid)
        {
          return BadRequest(ModelState);
        }

        var game = await _context.Reservation.FindAsync(id);
        if (Reservation == null)
        {
          return NotFound();
        }

        _context.SaveChangesAsync();

        return Ok(Reservation);
      }
    }

}