namespace Training.CoalesceApp.Data.Models.BaseModel;
public class EventBase
{
    [Required]
    public string EventId { get; set; } = null!;

    public Event? Event { get; set; }
}

// Coalesce Notes:
// - This class will serve as a base class for our Trivia questions and answers. This helps us later when we add in multi-tenancy.
// - We are using GUIDs here because the event ID's will sometimes be used inside of a public access URL. This will help prevent users from guessing other event ID's.