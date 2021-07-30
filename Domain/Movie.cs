using System;

namespace DIO.Series
{
    public class Movie : Base
    {

        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int RealeaseYear { get; set; }

        private bool Removed { get; set; }
        public Movie(int id, Genre genre, string title, int realeaseYear, string description)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.RealeaseYear = realeaseYear;
            //The best option is not remove a record
            //just update as a removed
            this.Removed = false;
        }
        public override string ToString()
        {
            string message = "";
            message += "Genre: " + this.Genre + Environment.NewLine;
            message += "Title: " + this.Title + Environment.NewLine;
            message += "Description: " + this.Description + Environment.NewLine;
            message += "Year: " + this.RealeaseYear + Environment.NewLine;
            message += "Removed: " + (this.Removed ? "*Removed*" : "");
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
        public bool IsRemoved()
        {
            return this.Removed;
        }
        public void Remove()
        {
            this.Removed = true;

        }
    }
}