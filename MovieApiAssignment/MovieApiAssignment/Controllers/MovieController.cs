using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAssignment.Entities;
using ApiAssignment.Services;
namespace ApiAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieService service;
        public MovieController()
        {
            this.service = new MovieService();
        }
        [Route("GetAllMovies")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Movie> movies = service.GetAll();
            return StatusCode(200, movies);
        }
        [HttpGet]
        [Route("GetMovieById/{id}")]
        public IActionResult GetMovieById(int id)
        {
            Movie movie = service.GetMovieById(id);
            return StatusCode(200, movie);
        }
        [HttpGet]
        [Route("GetMovieByActor/{Actor}")]
        public IActionResult GetMovieByActor(string actor)
        {
            Movie movie = service.GetMovieByActor(actor);
            return StatusCode(200, movie);
        }
        [HttpGet]
        [Route("GetMovieByLang/{lang}")]
        public IActionResult GetMovieByLang(string lang)
        {
            Movie movie = service.GetMovieByLang(lang);
            return StatusCode(200, movie);
        }
        [HttpGet]
        [Route("GetMovieByDirector/{director}")]
        public IActionResult GetMovieById(string director)
        {
            Movie movie = service.GetMovieByDirector(director);
            return StatusCode(200, movie);
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Movie movie)
        {
            service.Add(movie);
            return StatusCode(200, movie);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            service.Delete(id);
            return StatusCode(200, "Movie with " + id + " Deleted");
        }
        [HttpPut]
        [Route("Edit")]
        public IActionResult Edit(Movie movie)
        {
            service.Edit(movie);
            return StatusCode(200, movie);
        }

    }
}
