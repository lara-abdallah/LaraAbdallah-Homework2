using LaraAbdallah_Homework2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaraAbdallah_Homework2.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Movies> Movieslist { get; set; }

    }
    }