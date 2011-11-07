namespace Blueprints.Contracts
{
	public interface ILabel
	{
	}

	public interface ILabel<out TLabelContent> : ILabel
	{
		TLabelContent Content { get; }
	}
}