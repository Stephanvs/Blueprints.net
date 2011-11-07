namespace Blueprints.Contracts
{
	/// <summary>
	/// Identifier of objects in the graph. Identifies both vertices and edges.
	/// </summary>
	/// <remarks>Should be unique for every element within the graph.</remarks>
	public interface IIdentifier
	{
	}

	public interface IIdentifier<out TId> : IIdentifier
	{
		TId Id { get; }
	}
}