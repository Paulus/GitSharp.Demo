using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace GitSharp.Demo
{
    public class Graph
    {
        public Point Position { get; set; }
        public List<string> Authors = new List<string>();
        public Dictionary<Commit, GraphNode> Nodes = new Dictionary<Commit, GraphNode>();

        public Graph()
        {
            Position = new Point(100.0, 1000.0);
        }

       public Commit Head
        {
            get
            {
                return m_head;
            }
            set
            {
                m_head = value;
                var list = m_head.Ancestors.ToList();
                foreach (var commit in list)
                    Add(commit);
            }
        }
        Commit m_head;

        public void Add(Commit node)
        {
            node.Graph = this;
            node.InitPosition();
            Nodes[commit] = new GraphNode() { Commit = commit };
        }
    }
}
