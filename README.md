# EventEase — Interactive Blazor WebAssembly Event Management App

Built as the final capstone project for Microsoft's *Blazor for Front-End Development* course, with assistance from Microsoft Copilot.

## Features Implemented
- **EventCard Component (`EventCard.razor`)**: Reusable card displaying event title, date, location, available seats, and two-way data binding (`@bind-Value` / `@bind`) with `EventCallback` notifications.
- **Routing & Navigation (`App.razor`, `Events.razor`, `EventDetails.razor`, `Register.razor`)**: Parameterized routes (`/events`, `/events/{Id:int}`, `/register/{EventId:int}`), programmatic navigation via `NavigationManager`, and a clean `<NotFound>` fallback handler.
- **Performance & Validation Optimization**: Uses `@key` directives on rendered collections to eliminate unnecessary DOM re-renders, `ShouldRender()` guards, and `EditForm` with `DataAnnotationsValidator` for strict client-side validation.
- **User Session State & Attendance Tracker (`UserSessionService.cs`, `AttendanceTracker.razor`)**: Scoped state management persisting registered events, active user session data, and real-time attendance check-in tracking.

## Running Locally
```bash
dotnet restore
dotnet run
```
