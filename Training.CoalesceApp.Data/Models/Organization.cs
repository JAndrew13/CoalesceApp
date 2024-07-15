namespace Training.CoalesceApp.Data.Models;
public class Organization
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string OrganizationId { get; set; } = null!;

    [Required]
    public required string Name { get; set; }
}

// Coalesce Notes:
// - This class has an application user associated to it via the "Identity" Attribute 