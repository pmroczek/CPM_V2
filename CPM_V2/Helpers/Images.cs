using GraphVizWrapper;
using GraphVizWrapper.Commands;
using GraphVizWrapper.Queries;
using QuickGraph;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace CPM.Helpers
{
	public class Images
	{
		#region Field

		private const int WidthX = 25;
		private const int HeightY = 25;
		private const int Overflow = 20;
		private AdjacencyGraph<Node, TaggedEdge<Node, string>> _graph;
		private Font _defaultFont = new Font("Arial", 8);

		#endregion

		#region Contructor

		public Images(AdjacencyGraph<Node, TaggedEdge<Node, string>> graph)
		{
			_graph = graph;
		}

		#endregion

		#region Public Method

		public Image GetImage(Bitmap bmp)
		{
			var sortedVertices = _graph.Vertices.OrderBy(v => v.Number);
			var printNumbers = new List<int>();
			using (var g = Graphics.FromImage(bmp))
			{
				g.DrawString("0", _defaultFont, Brushes.Black, 0, 0);
				int actualProcesCount = 1;
				int actualWidth = 0;
				foreach (var vertex in sortedVertices)
				{
					if (vertex.Number.HasValue)
					{
						int x = vertex.Number.Value * WidthX;
						int y = Overflow;
						int width = vertex.Time * WidthX;

						if (x < actualWidth)
						{
							y = HeightY * actualProcesCount + Overflow;
							actualProcesCount += 1;
						}
						else
						{
							actualWidth = x + HeightY;
							actualProcesCount = 1;
						}

						Rectangle rectangele = new Rectangle(x, y, width, HeightY);
						g.FillRectangle(Brushes.Cyan, rectangele);
						g.DrawString(vertex.Name, _defaultFont, Brushes.Black, rectangele);
						g.DrawRectangle(Pens.Black, rectangele);

						if (!printNumbers.Contains(vertex.Number.Value + vertex.Time))
						{
							g.DrawString((vertex.Number.Value + vertex.Time).ToString(), _defaultFont, Brushes.Black, x + width, 0);
							printNumbers.Add(vertex.Number.Value);
						}
					}
				}
			}
			return bmp;
		}

		public static Image GetImageGraph(string output)
		{
			var getStartProcessQuery = new GetStartProcessQuery();
			var getProcessStartInfoQuery = new GetProcessStartInfoQuery();
			var registerLayoutPluginCommand = new RegisterLayoutPluginCommand(getProcessStartInfoQuery, getStartProcessQuery);
			var wrapper = new GraphGeneration(getStartProcessQuery, getProcessStartInfoQuery, registerLayoutPluginCommand);
			var outputImg = wrapper.GenerateGraph(output, Enums.GraphReturnType.Png);
			return Image.FromStream(new MemoryStream(outputImg));
		}

		#endregion Public Method
	}
}
