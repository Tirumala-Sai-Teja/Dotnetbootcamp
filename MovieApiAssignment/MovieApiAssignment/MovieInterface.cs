using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAssignment.Entities;
namespace ApiAssignment.Interfaces
{
    public interface MovieInterface
    {
        List<Movie> GetAll();
        Movie GetMovieById(int id);
        Movie GetMovieByActor(string actor);
        Movie GetMovieByLang(string lang);
        Movie GetMovieByDirector(string director);

        void Add(Movie movie);
        void Delete(int id);
        void Edit(Movie movie);
    }
}