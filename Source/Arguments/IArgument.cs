namespace NiTiS.Net.Arguments;
public interface IArgument
{
	/// <summary>
	/// Get argument
	/// </summary>
	/// <returns>"<c>argumentName</c>=<c>value</c>"</returns>
	public string Create(uint position);
}
