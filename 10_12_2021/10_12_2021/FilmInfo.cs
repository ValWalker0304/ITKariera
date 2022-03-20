using System;
using System.Collections.Generic;
using System.Text;

namespace _10_12_2021
{
    public class FilmInfo
    {
        private string name;
        private int date;
        private string genre;

        public int Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Genre
        {
            get { return this.genre; }
            set { this.genre = value; }
        }

        public FilmInfo() { }
        /*public FilmInfo(int date, string genre, string name)
        {
            this.date = date;
            this.genre = genre;
            this.name = name;

        }*/
        public static void AddToDictionary(Dictionary<string, FilmInfo> films,
    string name, string genre, int date)
        {
            FilmInfo theFilm = new FilmInfo();

            theFilm.Name = name;
            theFilm.Genre = genre;
            theFilm.Date = date;

            films.Add(key: theFilm.ToString(), value: theFilm);
        }

        public static void AddToList(List<FilmInfo> films, string name, string genre, int date) 
        {
            FilmInfo theFilm = new FilmInfo();
            theFilm.Name = name;
            theFilm.Genre = genre;
            theFilm.Date = date;
            films.Add(theFilm);
        }
        public void Print()
        {
            Console.WriteLine($" Movie: {this.name}, genre - {this.genre}, date {this.date} year");
        }
    }
}
