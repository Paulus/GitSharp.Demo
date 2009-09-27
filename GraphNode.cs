using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace GitSharp.Demo
{
    public class GraphNode
    {
        public Commit Commit { get; set; }
        public Point Pos { get; set; }
        public Graph Graph { get; set; }



        internal void InitPosition()
        {
            if (Graph.HeadNode == this)
            {
                Pos = Graph.Position;
                return;
            }
            var y = (double)((Commit.Author.When.Ticks - Graph.Head.Author.When.Ticks) / 360000000000L);
            var author = Author;
            double x = 0.0;
            if (Graph.Authors.Contains(author))
                x = Graph.Position.X + Graph.Authors.IndexOf(author) * 50.0;
            else
            {
                x = Graph.Position + Graph.Authors.Count * 50.0;
                Graph.Authors.Add(author);
            }
            Pos = new Point(x, y);
        }

        public string Author
        {
            get
            {
                return Commit.Author.Name + " " + Commit.Author.EmailAddress;
            }
        }
    }
}
