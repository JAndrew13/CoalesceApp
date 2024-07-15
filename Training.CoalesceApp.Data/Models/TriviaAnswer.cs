using Training.CoalesceApp.Data.Models.BaseModel;

namespace Training.CoalesceApp.Data.Models;
public class TriviaAnswer : EventBase
{
    public int TriviaAnswerId { get; set; }

    [Required]
    public required string Text { get; set; } = null!;

    [Required]
    public bool IsCorrect { get; set; }

    [Required]
    public int TriviaQuestionId { get; set; }
    public TriviaQuestion? TriviaQuestion { get; set; }
}

// Coalesce Notes:
// This is separated from TriviaQuestion because it will be used in a different context. This is a best practice for keeping your models clean and organized.
// If the only time you ever use an object is with a second object, then its good to keep them together, other wise keep them separate.
