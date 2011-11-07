namespace Blueprints.Contracts
{
	/// <summary>
	/// An edge links to two vertices. An edge has both a directionality and a label.
	/// The directionality determines which vertex is the tail vertex (out vertex) and which vertex is the head vertex (in vertex).
	/// The label determines the type of relationship that exists between the two vertices.
	/// Diagrammatically, outVertex ---label---> inVertex.
	/// </summary>
	public interface IEdge : IElement
	{
		/// <summary>
		/// Get the associated label describing the relationship between the vertices.
		/// </summary>
		ILabel Label { get; }

		/// <summary>
		/// Return the vertex on the tail of the edge.
		/// </summary>
		/// <returns></returns>
		IVertex GetOutVertex();

		/// <summary>
		/// Return the vertex on the head of the edge.
		/// </summary>
		/// <returns></returns>
		IVertex GetInVertex();
	}

	public interface IEdge<out TEdgeData> : IEdge
	{
		TEdgeData Data { get; }
	}
}