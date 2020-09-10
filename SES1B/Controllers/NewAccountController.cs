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
    [Route("api/[controller]")]
    [ApiController]
    public class NewAccountController : ControllerBase
    {
        private readonly NewAccountContext _context;

        public NewAccountController(NewAccountContext context)
        {
            _context = context;
        }

        // GET: api/NewAccount
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewAccount>>> GetNewAccounts()
        {
            return await _context.NewAccounts.ToListAsync();
        }

        // GET: api/NewAccount/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NewAccount>> GetNewAccount(int id)
        {
            var newAccount = await _context.NewAccounts.FindAsync(id);

            if (newAccount == null)
            {
                return NotFound();
            }

            return newAccount;
        }

        // PUT: api/NewAccount/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNewAccount(int id, NewAccount newAccount)
        {
            

            _context.Entry(newAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewAccountExists(id))
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

        private bool NewAccountExists(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/NewAccount
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NewAccount>> PostNewAccount(NewAccount newAccount)
        {
            _context.NewAccounts.Add(newAccount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNewAccount", new { id = newAccount.Id }, newAccount);
        }

        // DELETE: api/NewAccount/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NewAccount>> DeleteNewAccount(int id)
        {
            var newAccount = await _context.NewAccounts.FindAsync(id);
            if (newAccount == null)
            {
                return NotFound();
            }

            _context.NewAccounts.Remove(newAccount);
            await _context.SaveChangesAsync();

            return newAccount;
        }

       // private bool NewAccountExists(int id)
       // {
         //   return _context.NewAccounts.Any(e => e.Id == id);
        //}

       // public IActionResult Register(NewAccountController vm)
        //{
          //  if (!ModelState.IsValid) 
            //    return //whatever the model is

           // var user = new ApplicationUser {UserName - vmmEmail, Email = vm. }


        }
}