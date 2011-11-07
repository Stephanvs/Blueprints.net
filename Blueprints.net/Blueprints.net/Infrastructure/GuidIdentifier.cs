using System;
using Blueprints.Contracts;

namespace Blueprints.Infrastructure
{
	public class GuidIdentifier : IIdentifier<Guid>
	{
		public GuidIdentifier()
		{
			Id = Guid.NewGuid();
		}

		public GuidIdentifier(Guid id)
		{
			Id = id;
		}

		public Guid Id { get; private set; }
	}
}
