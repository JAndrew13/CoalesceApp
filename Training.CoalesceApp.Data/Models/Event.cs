using Training.CoalesceApp.Data.Models.BaseModel;

namespace Training.CoalesceApp.Data.Models;

public class Event : OrganizationBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string EventId { get; set; } = null!;

    [Required]
    public required string Name { get; set; }

    [Required]
    public required DateTimeOffset Start { get; set; }
    public required DateTimeOffset End { get; set; }
}

// Coalesce Notes:
// - This class is associated with an organization ID via the "OrganizationBase" class.