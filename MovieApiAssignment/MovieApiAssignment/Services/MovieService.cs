using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAssignment.Entities;
using ApiAssignment.Interfaces;
using ApiAssignment.Database;
namespace ApiAssignment.Services
{
    public class MovieService : MovieInterface
    {
        private readonly MovieDBContext context;
        public MovieService()
        {
            this.context = new MovieDBContext();
        }
        public void Add(Movie movie)
        {
            context.Movies.Add(movie);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Movie movie = context.Movies.SingleOrDefault(i => i.MovieId == id);
            context.Movies.Remove(movie);
            context.SaveChanges();
        }

        public void Edit(Movie movie)
        {
            context.Movies.Update(movie);
            context.SaveChanges();
        }

        public Movie GetMovieById(int id)
        {
            Movie movie = context.Movies.SingleOrDefault(i => i.MovieId == id);
            return movie;
        }
        public Movie GetMovieByActor(string actor)
        {
            Movie movie = context.Movies.SingleOrDefault(i => i.Actor == actor);
            return movie;
        }
        public Movie GetMovieByLang(string lang)
        {
            Movie movie = context.Movies.SingleOrDefault(i => i.Lang == lang);
            return movie;
        }
        public Movie GetMovieByDirector(string director)
        {
            Movie movie = context.Movies.SingleOrDefault(i => i.Director == director);
            return movie;
        }

        public List<Movie> GetAll()
        {
            return context.Movies.ToList();
        }
    }
}
