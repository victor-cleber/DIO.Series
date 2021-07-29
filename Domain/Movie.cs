using System;

namespace DIO.Series
{
    public class Movie : Base
    {

        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        public Movie(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
        }
        public override string ToString()
        {
            string message = "";
            message += "Genre: " + this.Genre + Environment.NewLine;
            message += "Title: " + this.Title + Environment.NewLine;
            message += "Description: " + this.Description + Environment.NewLine;
            message += "Year: " + this.Year;
            return message;
        }

        public string returnTitle()
        {
            return this.Title;

        }
        public int returnId()
        {
            return this.Id;
        }
    }
}