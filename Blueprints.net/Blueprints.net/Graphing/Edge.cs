using System;
using Blueprints.Contracts;

namespace Blueprints.Graphing
{
	public class Edge<TEdgeData> :
		Element,
		IEdge<TEdgeData>
	{
		public Edge(IIdentifier identifier) :
			base(identifier)
		{
		}

		#region IEdge<TEdgeData> Members

		public TEdgeData Data
		{
			get { throw new NotImplementedException(); }
		}

		public ILabel Label
		{
			get { throw new NotImplementedException(); }
		}

		public IVertex GetOutVertex()
		{
			throw new NotImplementedException();
		}

		public IVertex GetInVertex()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}