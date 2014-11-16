using CPM.Helpers;
using CPM.Properties;
using QuickGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CPM.Controls
{
	public partial class AddNode : UserControl
	{
		#region Field

		private AdjacencyGraph<Node, TaggedEdge<Node, string>> _graph;
		private Node _vertex;

		#endregion

		#region Constructor

		public AddNode(AdjacencyGraph<Node, TaggedEdge<Node, string>> graph)
		{
			InitializeComponent();
			_graph = graph;
			cbxNeighbors.DataSource = GetVerticesNames();
		}

		#endregion Construcotor

		#region Private Method

		private List<string> GetVerticesNames()
		{
			return _graph.Vertices.Select(v => v.Name).ToList();
		}

		private void ResetDataToDefault()
		{
			cbxNeighbors.DataSource = null;
			cbxNeighbors.DataSource = GetVerticesNames();
			tbNodeName.Text = string.Empty;
			tbDuration.Text = string.Empty;
		}

		#endregion Private Method

		#region Events

		private void btnAdd_Click(object sender, EventArgs e)
		{
			int time;
			string nodeName = Regex.Replace(tbNodeName.Text, "[^A-Za-z0-9_]", "");
			if (!string.IsNullOrEmpty(tbDuration.Text) && Int32.TryParse(tbDuration.Text, out time) && time >= 0)
				if (!string.IsNullOrEmpty(nodeName) && _graph.Vertices.All(v => v.Name != nodeName))
				{
					_vertex = new Node(time, nodeName);
					_graph.AddVertex(_vertex);

					foreach (var nodes in cbxNeighbors.CheckedItems.OfType<String>())
					{
						var source = _graph.Vertices.First(v => v.Name == nodes);
						_graph.AddEdge(new TaggedEdge<Node, string>(source, _vertex, "null"));
					}
					
					(this.Parent as Form1).EnableDisableButtons(true);
					MessageBox.Show(string.Format(Resources.SuccessfullAddNode, _vertex), "", MessageBoxButtons.OK);
					ResetDataToDefault();
				}
				else
					MessageBox.Show(Resources.VerticesNameWarning, Resources.TitleWarning, MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show(Resources.TimeWarning, Resources.TitleWarning, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		#endregion
	}
}
