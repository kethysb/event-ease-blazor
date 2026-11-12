using EventEase.Models;

namespace EventEase.Services;

public class UserSessionService
{
    public string CurrentUserName { get; private set; } = "Guest User";
    public string CurrentUserEmail { get; private set; } = string.Empty;
    public bool IsAuthenticated => !string.IsNullOrWhiteSpace(CurrentUserEmail);

    private readonly List<RegistrationModel> _registrations = new();
    public IReadOnlyList<RegistrationModel> Registrations => _registrations.AsReadOnly();

    public event Action? OnSessionChanged;

    public void StartSession(string name, string email)
    {
        CurrentUserName = name;
        CurrentUserEmail = email;
        OnSessionChanged?.Invoke();
    }

    public void AddRegistration(RegistrationModel registration)
    {
        StartSession(registration.FullName, registration.Email);
        _registrations.Add(registration);
        OnSessionChanged?.Invoke();
    }

    public void ToggleCheckIn(RegistrationModel registration)
    {
        registration.CheckedIn = !registration.CheckedIn;
        OnSessionChanged?.Invoke();
    }
}
