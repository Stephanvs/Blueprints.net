using System.Collections.Generic;

namespace Blueprints.Contracts
{
	/// <summary>
	/// An element is the base class for both vertices and edges.
	/// An element has an identifier that mush be unique within the graph.
	/// An element can maintain a collection of key/value properties.
	/// Keys are always strings, and values can be of any object type.
	/// </summary>
	public interface IElement
	{
		/// <summary>
		/// An identifier that is unique within the graph. So every element within the graph must have a unique identifier.
		/// </summary>
		IIdentifier Id { get; }

		/// <summary>
		/// A collection of properties for this element.
		/// </summary>
		IDictionary<string, object> Properties { get; }
	}
}