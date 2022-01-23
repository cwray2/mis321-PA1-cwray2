using System;
namespace mis321_PA1_cwray2
{
    public class Song : IComparable<Song>
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Deleted { get; set; }

        public override string ToString()
        {
            return "ID: " + this.ID + " Title: " + this.Title + " Time Stamp: " + this.DateAdded;
        }

        public string ToFile()
        {
            return this.ID + "#" + this.Title + "#" + this.DateAdded + "#" + this.Deleted;
        }

        public int CompareTo(Song temp)
        {
            return this.DateAdded.CompareTo(temp.DateAdded);
        }
    }
}