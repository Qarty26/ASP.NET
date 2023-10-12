using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Materie
    {
        public string Title { get; set; }
        public string Duration { get; set; }
        public int Credits { get; set; }
        public bool HasLab { get; set; }



        public Materie()
        {
            Title = string.Empty;
            Duration = string.Empty;
            Credits = 0;
            HasLab = false;
        }
        public Materie(string Title, string Duration, int Credits, bool HasLab)
        {
            this.Title = Title;
            this.Duration = Duration;
            this.Credits = Credits;
            this.HasLab = HasLab;
        }

        public void Afisare()
        {
            Console.WriteLine(Title + " " + Duration + " Credits:" + Credits + " Lab:" + HasLab);
        }
    }
}
