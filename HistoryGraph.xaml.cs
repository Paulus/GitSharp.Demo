using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GitSharp.Demo
{
    /// <summary>
    /// Interaction logic for HistoryGraph.xaml
    /// </summary>
    public partial class HistoryGraph : UserControl
    {
        public HistoryGraph()
        {
            InitializeComponent();
        }

        Repository Repository { get; set; }
        Graph Graph { get; set; }

        private void OnDraw(object sender, RoutedEventArgs e)
        {
            m_canvas.Children.Clear();
            if (Repository == null)
                return;
            var head = repo.OpenCommit(repo.Head.ObjectId) as Commit;
            Graph = new Graph();
            Graph.Head = head;
        }
    }
}
