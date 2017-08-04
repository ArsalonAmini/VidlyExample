using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using VidlyExample.Models;
using VidlyExample.DTO;

namespace VidlyExample.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDTO newRental)
        {
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.StockNumber == 0)
                    return BadRequest("Movie is not available");

                movie.StockNumber--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
            }

            _context.Rental.Add(rental);
            return Ok();
        }
    }
}

   // public class RentNewMovie (Customer, Movie){
      //  customer = _context.dbset


