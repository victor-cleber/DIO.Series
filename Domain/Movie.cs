using System;

namespace DIO.Series
{
    public class Movie : Base
    {

        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int RealeaseYear { get; set; }
        public Movie(int id, Genre genre, string title, string description, int realeaseYear)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.RealeaseYear = year;
        }
        public override string ToString()
        {
            string message = "";
            message += "Genre: " + this.Genre + Environment.NewLine;
            message += "Title: " + this.Title + Environment.NewLine;
            message += "Description: " + this.Description + Environment.NewLine;
            message += "Year: " + this.RealeaseYear;
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