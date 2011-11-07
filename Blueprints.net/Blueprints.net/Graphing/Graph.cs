using Blueprints.Contracts;
using Blueprints.Infrastructure;

namespace Blueprints.Graphing
{
	public class SimpleInMemoryGraph : IGraph
	{
		private UniqueGuidIdentifierGenerator uniqueIdentifierGenerator;

		public SimpleInMemoryGraph(IUniqueIdentifierGenerator uniqueIdentifierGenerator)
		{
		}

		public IVertex AddVertex(IIdentifier vertexId)
		{
			throw new System.NotImplementedException();
		}

		public IVertex AddVertex<TVertexData>(IIdentifier vertexId, TVertexData data = default(TVertexData))
		{
			throw new System.NotImplementedException();
		}

		public IVertex GetVertex(IIdentifier vertexId)
		{
			throw new System.NotImplementedException();
		}

		public void RemoveVertex(IVertex vertex)
		{
			throw new System.NotImplementedException();
		}

		public void RemoveVertex(IIdentifier vertexId)
		{
			throw new System.NotImplementedException();
		}

		public System.Collections.Generic.IEnumerable<IVertex> GetVertices()
		{
			throw new System.NotImplementedException();
		}

		public IEdge AddEdge(IIdentifier edgeId, IVertex outVertex, IVertex inVertex, ILabel label = default(Label))
		{
			throw new System.NotImplementedException();
		}

		public IEdge AddEdge<TEdgeData>(IIdentifier edgeId, IVertex outVertex, IVertex inVertex, ILabel label = default(Label), TEdgeData data = default(TEdgeData))
		{
			throw new System.NotImplementedException();
		}

		public IEdge GetEdge(IIdentifier edgeId)
		{
			throw new System.NotImplementedException();
		}

		public void RemoveEdge(IEdge edge)
		{
			throw new System.NotImplementedException();
		}

		public void RemoveEdge(IIdentifier edgeId)
		{
			throw new System.NotImplementedException();
		}

		public System.Collections.Generic.IEnumerable<IEdge> GetEdges()
		{
			throw new System.NotImplementedException();
		}

		public IGraphOptions Options
		{
			get { throw new System.NotImplementedException(); }
		}

		public void Clear()
		{
			throw new System.NotImplementedException();
		}

		public void Shutdown()
		{
			throw new System.NotImplementedException();
		}
	}
}