using System.Collections.Generic;
using Blueprints.Graphing;

namespace Blueprints.Contracts
{
	/// <summary>
	/// A graph is a container object for a collection of vertices and edges.
	/// </summary>
	public interface IGraph
	{
		/// <summary>
		/// Create a new vertex, add it to the graph, and return the newly created vertex.
		/// The provided <paramref name="vertexId"/> is a recommendation for the identifier to use.
		///		* It is not required that the implementation uses this identifier.
		///		* If the <paramref name="vertexId"/> is already used by the graph to reference a vertex,
		///		  then that reference will be returned and no vertex is created.
		/// </summary>
		/// <param name="vertexId">Recommended identifier to use for the vertex to be created.</param>
		/// <returns>The newly created vertex, or the vertex already referenced by the provided identifier</returns>
		IVertex AddVertex(IIdentifier vertexId);

		/// <summary>
		/// Create a new vertex, add it to the graph, and return the newly created vertex.
		/// The provided <paramref name="vertexId"/> is a recommendation for the identifier to use.
		///		* It is not required that the implementation uses this identifier.
		///		* If the <paramref name="vertexId"/> is already used by the graph to reference a vertex,
		///		  then that reference will be returned and no vertex is created.
		/// </summary>
		/// <typeparam name="TVertexData">The type to use as an additional data property on the vertex.</typeparam>
		/// <param name="vertexId">Recommended identifier to use for the vertex to be created.</param>
		/// <param name="data">Optional data object to initally fill the to be created vertex with.</param>
		/// <returns>The newly created vertex, or the vertex already referenced by the provided identifier</returns>
		IVertex AddVertex<TVertexData>(IIdentifier vertexId, TVertexData data = default(TVertexData));

		/// <summary>
		/// Return the vertex referenced by the provided <see name="IIdentifier"/>.
		/// </summary>
		/// <param name="vertexId">The identifier of the vertex to be retrieved from the graph.</param>
		/// <returns>The vertex referenced by the provided <see name="IIdentifier"/>, or null if no such vertex exists.</returns>
		IVertex GetVertex(IIdentifier vertexId);

		/// <summary>
		/// Remove the provided vertex from the graph.
		/// </summary>
		/// <param name="vertex">The vertex to remove from the graph.</param>
		void RemoveVertex(IVertex vertex);

		/// <summary>
		/// Remove the vertex with the associated <paramref name="vertexId"/> from the graph.
		/// </summary>
		/// <param name="vertexId">The identifier of the vertex to be removed.</param>
		void RemoveVertex(IIdentifier vertexId);

		/// <summary>
		/// Return an enumerable reference to all the vertices in the graph.
		/// </summary>
		/// <returns>An enumerable collection to all the vertices in the graph.</returns>
		IEnumerable<IVertex> GetVertices();

		/// <summary>
		/// Add an edge to the graph. The added edges require a recommended <see name="IIdentifier"/>, a tail <see cref="IVertex"/>, a head <see cref="IVertex"/>, and optionally an <see cref="ILabel"/>.
		/// Like adding a vertex, the provided <paramref name="edgeId"/> is optional and may be ignored by the graph implementation.
		/// </summary>
		/// <param name="edgeId">The recommended object identifier.</param>
		/// <param name="outVertex">The vertex on the tail of the edge.</param>
		/// <param name="inVertex">The vertex on the head of the edge.</param>
		/// <param name="label">The label associated with the edge.</param>
		/// <returns>The newly created edge.</returns>
		IEdge AddEdge(IIdentifier edgeId, IVertex outVertex, IVertex inVertex, ILabel label = default(Label));

		/// <summary>
		/// Add an edge to the graph. The added edges require a recommended <see name="IIdentifier"/>, a tail <see cref="IVertex"/>, a head <see cref="IVertex"/>, and optionally an <see cref="ILabel"/>.
		/// Like adding a vertex, the provided <paramref name="edgeId"/> is optional and may be ignored by the graph implementation.
		/// </summary>
		/// <param name="edgeId">The recommended object identifier.</param>
		/// <param name="outVertex">The vertex on the tail of the edge.</param>
		/// <param name="inVertex">The vertex on the head of the edge.</param>
		/// <param name="label">The label associated with the edge.</param>
		/// <param name="data">Optional data object to initally fill the to be created edge with.</param>
		/// <returns>The newly created edge.</returns>
		IEdge AddEdge<TEdgeData>(IIdentifier edgeId, IVertex outVertex, IVertex inVertex, ILabel label = default(Label),
		                         TEdgeData data = default(TEdgeData));

		/// <summary>
		/// Return the edge referenced by the provided <see cref="IIdentifier"/>.
		/// </summary>
		/// <param name="edgeId">The identifier of the edge to be retrieved from the graph.</param>
		/// <returns>The edge referenced by the provided <see cref="IIdentifier"/>, or null if no such edge exists.</returns>
		IEdge GetEdge(IIdentifier edgeId);

		/// <summary>
		/// Remove the provided edge from the graph.
		/// </summary>
		/// <param name="edge">The edge to remove from the graph.</param>
		void RemoveEdge(IEdge edge);

		/// <summary>
		/// Remove the edge with the associated <paramref name="edgeId"/> from the graph.
		/// </summary>
		/// <param name="edgeId">The identifier of the vertex to be removed.</param>
		void RemoveEdge(IIdentifier edgeId);

		/// <summary>
		/// Return an enumerable reference to all the edges in the graph.
		/// </summary>
		/// <returns>An enumerable collection with all the edges in the graph.</returns>
		IEnumerable<IEdge> GetEdges();

		/// <summary>
		/// Remove all vertices and edges from the graph.
		/// </summary>
		void Clear();

		/// <summary>
		/// A shutdown function is required to properly close the graph.
		/// This is important for implementations that utilize disk-based serializations.
		/// </summary>
		void Shutdown();
	}
}