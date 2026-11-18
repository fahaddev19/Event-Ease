using EventEase.Models;

namespace EventEase.Services;

public interface IEventService
{
    List<EventModel> GetAllEvents();
    EventModel? GetEventById(int id);
}

public class EventService : IEventService
{
    private static readonly List<EventModel> MockEvents = new()
    {
        new EventModel
        {
            Id = 1,
            Title = "Tech Innovators Summit 2026",
            Date = new DateTime(2026, 6, 15, 9, 30, 0),
            Location = "Metropolitan Convention Center, Hall A",
            Description = "Join global tech leaders, AI engineers, and industry visionaries to explore breakthroughs in artificial intelligence, cloud architecture, and modern application ecosystems."
        },
        new EventModel
        {
            Id = 2,
            Title = "Full-Stack Blazor & Cloud Masterclass",
            Date = new DateTime(2026, 7, 20, 10, 0, 0),
            Location = "Downtown Tech Hub & Online Live Stream",
            Description = "An intensive deep-dive into high-performance full-stack Blazor web development, server/WASM render modes, C# state management, and enterprise deployment."
        },
        new EventModel
        {
            Id = 3,
            Title = "Cybersecurity & DevOps World Forum",
            Date = new DateTime(2026, 8, 5, 13, 0, 0),
            Location = "Silicon Valley Innovation Arena",
            Description = "Discover cutting-edge strategies for zero-trust security, CI/CD pipeline automation, threat modeling, and resilient infrastructure management."
        }
    };

    public List<EventModel> GetAllEvents() => MockEvents.ToList();

    public EventModel? GetEventById(int id) => MockEvents.FirstOrDefault(e => e.Id == id);
}
