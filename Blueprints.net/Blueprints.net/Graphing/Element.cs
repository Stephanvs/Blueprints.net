using System.Collections.Generic;
using Blueprints.Contracts;

namespace Blueprints.Graphing
{
	public abstract class Element : IElement
	{
		protected Element(IIdentifier identifier)
		{
			Id = identifier;
		}

		public IIdentifier Id { get; private set; }
		
		public IDictionary<string, object> Properties { get; protected set; }
	}
}
