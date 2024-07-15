namespace Training.CoalesceApp.Data.Models.BaseModel;

public class OrganizationBase
{

    [Required]
    public string OrganizationId { get; set; } = null!;

    public Organization? Organization { get; set; }
}

// Coalesce Notes:
//  - This class will serve as an interface for all other models that are used by or apart of an Organization.

// [InternalUse] - This will not be included in the API when DTO's are generated. 