using CPM.Controls;
using CPM.Helpers;
using QuickGraph;
using QuickGraph.Graphviz;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CPM
{
	public partial class Form1 : Form
	{
		#region Field

		AdjacencyGraph<Node, TaggedEdge<Node, string>> _graph;

		#endregion

		#region Constructor

		public Form1()
		{
			_graph = new AdjacencyGraph<Node, TaggedEdge<Node, string>>();
			InitializeComponent();
		}

		#endregion Constructor

		#region Events

		private void btAddNode_Click(object sender, EventArgs e)
		{
			AddNode add = new AddNode(_graph);
			add.Location = new Point(13, 42);
			add.Visible = true;
			Controls.Add(add);
			EnableDisableButtons(false);
		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			var graphviz = new GraphvizAlgorithm<Node, TaggedEdge<Node, string>>(_graph);
			graphviz.FormatVertex += FormatVertex;
			graphviz.Generate(new FileDotEngine(), "graph");
			var img = Images.GetImageGraph(graphviz.Output.ToString());
			btnShowTimes.Image = img;
			btnShowTimes.Width = img.Width;
		}

		private void btnShowTimeScale_Click(object sender, System.EventArgs e)
		{
			Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			Images timeScale = new Images(_graph);
			pictureBox1.Image = timeScale.GetImage(bmp);
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			foreach (var verticy in _graph.Vertices)
			{
				if (!_graph.Edges.Any(ee => ee.Target.Equals(verticy)))
					verticy.Number = 0;
				else
					verticy.Number = _graph.Edges.Where(t => t.Target.Equals(verticy)).Distinct().Select(t => t.Source.Number + t.Source.Time).Max();
			}
			btnShowTimeScale.Enabled = true;
		}

		#endregion

		#region Public Method

		public void EnableDisableButtons(bool on)
		{
			btnShow.Enabled = on;
			btnCalculate.Enabled = on;
			btnShowTimeScale.Enabled = on;
		}

		#endregion

		#region Private Method

		private void FormatVertex(object sender, FormatVertexEventArgs<Node> e)
		{
			var vertex = e.Vertex;
			e.VertexFormatter.Label = vertex.Number != null ? string.Format("{0},T={1},L={2}", vertex.Name, vertex.Time, vertex.Number) : string.Format("{0},T={1}", vertex.Name, vertex.Time);
		}

		#endregion

		#region TEST
		private void btnTestGraph_Click(object sender, EventArgs e)
		{
			Node A = new Node(3, "A");
			Node B = new Node(1, "B");
			Node C = new Node(4, "C");
			Node D = new Node(1, "D");
			Node E = new Node(9, "E");
			Node F = new Node(5, "F");
			Node G = new Node(2, "G");

			_graph.AddVerticesAndEdge(new TaggedEdge<Node, string>(A, B, "null"));
			_graph.AddVerticesAndEdge(new TaggedEdge<Node, string>(A, C, "null"));
			_graph.AddVerticesAndEdge(new TaggedEdge<Node, string>(B, D, "null"));
			_graph.AddVerticesAndEdge(new TaggedEdge<Node, string>(C, D, "null"));
			_graph.AddVerticesAndEdge(new TaggedEdge<Node, string>(D, E, "null"));
			_graph.AddVerticesAndEdge(new TaggedEdge<Node, string>(D, F, "null"));
			_graph.AddVerticesAndEdge(new TaggedEdge<Node, string>(E, G, "null"));
			_graph.AddVerticesAndEdge(new TaggedEdge<Node, string>(F, G, "null"));

			btnShow.Enabled = true;
			btnCalculate.Enabled = true;
		}
		#endregion
	}
}