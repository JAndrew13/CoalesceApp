using Training.CoalesceApp.Data.Models.BaseModel;

namespace Training.CoalesceApp.Data.Models;
public class TriviaQuestion : EventBase
{
    public int TriviaQuestionId { get; set; }

    [Required]
    public required string Text { get; set; }

    public ICollection<TriviaAnswer> Answers { get; set; } = [];
}

// Coalesce Notes:
// This is separated from TriviaAnswer because it will be used in a different context. This is a best practice for keeping your models clean and organized.
// If the only time you ever use an object is with a second object, then its good to keep them together, other wise keep them separate.
