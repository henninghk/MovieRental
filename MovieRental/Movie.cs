using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace MovieRental
{
    class Movie
    {
        public string _name;
        public int _year;
        public int id;
        public List<Actor> _actorName;
        public Rent _price;
        public Director _director;


        public Movie( string name, int year, int id, Rent price, Director director, params Actor[] actorName)
        {
            _name = name;
            _year = year;
            this.id = id;
            _actorName = new List<Actor>(actorName);
            _price = price;
            _director = director;
        }


        public string ShowMovie()
        {
            string output = null;

            output = ShowMovieTitle(output);

            output += ShowMovieActors(output);

            output += ShowMoviedirector(output);

            output += ShowMovieRentalInfo(output);
            return output;
        }

        public string ShowMovieRentalInfo(string output)
        {
           if(_price != null)
           {
               output = _price.MovieRental();
           }

           return output;
        }

        public string ShowMoviedirector(string output)
        {
            if (_director != null)
            {
                output += _director.DirName();
            }
            return output;
        }

        public string ShowMovieActors(string output)
        {
            if (_actorName != null)
            {
                foreach (var name in _actorName)
                {
                   output +=  name.ActorName();
                }
            }
            

            return output;
        }

        public string ShowMovieTitle(string output)
        {
            if (_name != null)
            {
                output += "\n FilmTittel: " + _name;
            }

            return output;
        }

   

    }
}
