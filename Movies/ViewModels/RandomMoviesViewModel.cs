using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies.ViewModels
{
    public class RandomMoviesViewModel
    {
        public Movie movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}