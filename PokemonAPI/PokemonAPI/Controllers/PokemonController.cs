using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokemonAPI.Database;
using PokemonAPI.Models;
using PokemonAPI.Repositories;

namespace PokemonAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PokemonController(IPokemonRepository pokemonRepository) : ControllerBase
    {
        //private readonly PokemonContext _context;

        //public PokemonController(PokemonContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Pokemon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemon()
        {
            var pokemon = await pokemonRepository.GetPokemon();
            return Ok(pokemon);
        }

        // GET: api/Pokemon/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pokemon>> GetPokemon(int id)
        {
            var pokemon = await pokemonRepository.GetPokemonById(id);

            if (pokemon == null)
            {
                return NotFound();
            }

            return Ok(pokemon);
        }

        //// PUT: api/Pokemon/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPokemon(int id, Pokemon pokemon)
        //{
        //    if (id != pokemon.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(pokemon).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PokemonExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Pokemon
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Pokemon>> PostPokemon(Pokemon pokemon)
        //{
        //    _context.Pokemon.Add(pokemon);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetPokemon", new { id = pokemon.Id }, pokemon);
        //}

        //// DELETE: api/Pokemon/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeletePokemon(int id)
        //{
        //    var pokemon = await _context.Pokemon.FindAsync(id);
        //    if (pokemon == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Pokemon.Remove(pokemon);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool PokemonExists(int id)
        //{
        //    return _context.Pokemon.Any(e => e.Id == id);
        //}
    }
}
