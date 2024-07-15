using Training.CoalesceApp.Data.Models.BaseModel;

namespace Training.CoalesceApp.Data.Models;
public class ApplicationUser : OrganizationBase
{
    // Coalesce Question: If this is not allowed to be null could this just be set as required (like the other properties)?
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ApplicationUserId { get; set; } = null!;

    [Required]
    public required string Name { get; set; }

    [Required]
    public required string Email { get; set; }
}
