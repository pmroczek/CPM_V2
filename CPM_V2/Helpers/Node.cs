namespace CPM.Helpers
{
	public class Node
	{
		public Node(int time, string name)
		{
			Time = time;
			Name = name;
		}

		public int Time { get; private set; }
		public string Name { get; private set; }
		public int? Number { get; set; }

		public override string ToString()
		{
			return string.Format("name: {0} time: {1}", Name, Time);
		}

		public override bool Equals(object obj)
		{
			var tmp = (Node)obj;
			return tmp.Name == Name && tmp.Time == Time;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
