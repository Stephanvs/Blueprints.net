using Blueprints.Contracts;

namespace Blueprints.Infrastructure
{
	/// <summary>
	/// Generator that generates unique identifiers.
	/// </summary>
	public interface IUniqueIdentifierGenerator
	{
	}

	/// <summary>
	/// Generator that generates unique identifiers based on the given <typeparam name="TIdentifier"/>.
	/// </summary>
	public interface IUniqueIdentifierGenerator<out TIdentifier> : 
		IUniqueIdentifierGenerator
		where TIdentifier : IIdentifier
	{
		/// <summary>
		/// Generates the new identifier.
		/// </summary>
		/// <returns>A new <see cref="IIdentifier"/>.</returns>
		TIdentifier GenerateNewId();
	}
}