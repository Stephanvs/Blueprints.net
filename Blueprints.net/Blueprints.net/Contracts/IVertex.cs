using System.Collections.Generic;

namespace Blueprints.Contracts
{
	/// <summary>
	/// A vertex maintains pointers to both a set of incoming and outgoing edges.
	/// The outgoing edges are those for which this vertex is the tail.
	/// The incoming edges are those for which this vertex is the head.
	/// Diagrammatically, ---inEdges--> vertex ---outEdges-->
	/// </summary>
	public interface IVertex : IElement
	{
		/// <summary>
		/// The edges emanating from, or leaving this vertex.
		/// </summary>
		/// <returns>The edges for which this vertex is the tail.</returns>
		IEnumerable<IEdge> GetOutEdges();

		/// <summary>
		/// The edges coming into, or arriving at this vertex.
		/// </summary>
		/// <returns>The edges for which this vertex is the head.</returns>
		IEnumerable<IEdge> GetInEdges();
	}

	public interface IVertex<out TVertexData> : IVertex
	{
		TVertexData Data { get; }
	}
}