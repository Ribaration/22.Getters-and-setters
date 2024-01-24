using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Getters_and_setters
{
    internal class Program
    {
        class Movie 
        {
            public string title;
            public string director;
            public string rating;

            public Movie (string aTitle, string aDirector, string aRating)
            {
                this.title = aTitle;
                this.director = aDirector;
                this.rating = aRating;
            }

            public string Rating
            {
                get
                {
                    return rating;
                }

                set
                {
                    if (value == "G" || value == "PG" || value == "PG-13" || value == "NR" )
                    {
                        rating = value;
                    }
                    else
                    {
                        rating = "NR";
                    }
                } 
            }
        }
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Titanic", "Jim", "PG-13");
            Movie movie2 = new Movie("Unreleased", "Evans", "PG");
            Console.WriteLine(movie1.Rating);
            Console.ReadLine();

        }
    }
}
