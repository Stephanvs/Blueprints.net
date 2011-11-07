using System;
using System.Collections.Generic;
using Blueprints.Contracts;

namespace Blueprints.Graphing
{
	public class Vertex<TVertexData> :
		Element,
		IVertex<TVertexData>
	{
		public Vertex(IIdentifier identifier) :
			base(identifier)
		{
		}

		#region IVertex<TVertexData> Members

		public TVertexData Data
		{
			get { throw new NotImplementedException(); }
		}

		public IEnumerable<IEdge> GetOutEdges()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<IEdge> GetInEdges()
		{
			throw new NotImplementedException();
		}

		public IIdentifier Id
		{
			get { throw new NotImplementedException(); }
		}

		public IDictionary<string, object> Properties
		{
			get { throw new NotImplementedException(); }
		}

		#endregion
	}
}