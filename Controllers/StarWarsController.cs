using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarWarsAPI.Models;

namespace StarWarsAPI.Controllers
{
    public class StarWarsController : Controller
    {
        public async Task<IActionResult> Characters(int id)
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri("https://swapi.co/api/");

            var response = await client.GetAsync($"people/{id}");
            var result = await response.Content.ReadAsAsync<CharactersRoot>();

            return View(result);
        }

        public async Task<IActionResult> Planets(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");

            var response = await client.GetAsync($"planets/{id}");
            var result = await response.Content.ReadAsAsync<PlanetsRoot>();

            return View(result);
        }

        public IActionResult CharactersPlanets()
        {
            return View();
        }
    }
}