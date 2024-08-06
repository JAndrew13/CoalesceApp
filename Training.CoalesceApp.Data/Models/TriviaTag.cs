using Training.CoalesceApp.Data.Models.BaseModel;

namespace Training.CoalesceApp.Data.Models;
public class TriviaTag
{
    public int TriviaTagId { get; set; }

    [Required]
    public string Name { get; set; } = null!;
}
