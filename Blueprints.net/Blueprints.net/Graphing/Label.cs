using System;
using Blueprints.Contracts;

namespace Blueprints.Graphing
{
	public class Label : ILabel<String>
	{
		public string Content { get; protected set; } 

		public Label(string label = "")
		{
			Content = label;
		}

		public static ILabel Empty
		{
			get { return new Label(); }
		}
	}
}
