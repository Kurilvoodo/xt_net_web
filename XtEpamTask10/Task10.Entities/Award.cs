using System;
using System.Collections.Generic;
using System.Text;

namespace Task10.Entities
{
    public class Award
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Award(string title)
        {
            this.Title = title;
        }
        public override string ToString()
        {
            return $"Award" + Environment.NewLine +
                $"Id:{Id}" + Environment.NewLine +
                $"Title: {Title}" + Environment.NewLine;
        }
    }
}
