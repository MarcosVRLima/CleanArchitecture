namespace CleanArchitecture.Domain.Entities;

public sealed class User : BaseEntity
{
	public String? Email { get; set; }
	public String? Name { get; set; }
}
