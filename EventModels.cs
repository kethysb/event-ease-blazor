using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class EventModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Event name is required.")]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Event date is required.")]
    public DateTime Date { get; set; } = DateTime.Today.AddDays(7);

    [Required(ErrorMessage = "Location is required.")]
    [StringLength(120)]
    public string Location { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
    public int Capacity { get; set; } = 100;
    public int RegisteredCount { get; set; } = 0;
    public int CheckedInCount { get; set; } = 0;
}

public class RegistrationModel
{
    [Required(ErrorMessage = "Full name is required.")]
    [StringLength(80, MinimumLength = 2)]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email address is required.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Range(1, 10, ErrorMessage = "Ticket quantity must be between 1 and 10.")]
    public int Tickets { get; set; } = 1;

    public int EventId { get; set; }
    public bool CheckedIn { get; set; } = false;
    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
}
