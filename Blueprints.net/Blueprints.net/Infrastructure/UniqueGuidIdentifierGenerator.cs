namespace Blueprints.Infrastructure
{
	public class UniqueGuidIdentifierGenerator : IUniqueIdentifierGenerator<GuidIdentifier>
	{
		#region IUniqueIdentifierGenerator<GuidIdentifier> Members

		public GuidIdentifier GenerateNewId()
		{
			return new GuidIdentifier();
		}

		#endregion
	}
}