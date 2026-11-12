using EventEase.Models;

namespace EventEase.Services;

public class EventService
{
    private readonly List<EventModel> _events = new()
    {
        new EventModel { Id = 1, Name = "Tech Innovation Summit 2026", Date = new DateTime(2026, 11, 25), Location = "Seattle Convention Center, WA", Description = "Annual conference covering cloud-native .NET, Blazor, and AI engineering.", Capacity = 250, RegisteredCount = 142, CheckedInCount = 88 },
        new EventModel { Id = 2, Name = "Modern Web & Blazor Workshop", Date = new DateTime(2026, 12, 5), Location = "Virtual Live Stream", Description = "Hands-on full-stack workshop building interactive WebAssembly apps.", Capacity = 500, RegisteredCount = 310, CheckedInCount = 195 },
        new EventModel { Id = 3, Name = "Corporate Leadership Gala", Date = new DateTime(2026, 12, 18), Location = "Grand Hyatt New York, NY", Description = "Executive networking dinner and keynote presentations.", Capacity = 150, RegisteredCount = 98, CheckedInCount = 60 }
    };

    public Task<List<EventModel>> GetEventsAsync() => Task.FromResult(_events);

    public Task<EventModel?> GetEventByIdAsync(int id) =>
        Task.FromResult(_events.FirstOrDefault(e => e.Id == id));

    public void IncrementRegistration(int eventId, int tickets)
    {
        var ev = _events.FirstOrDefault(e => e.Id == eventId);
        if (ev is not null && ev.RegisteredCount + tickets <= ev.Capacity)
        {
            ev.RegisteredCount += tickets;
        }
    }
}
