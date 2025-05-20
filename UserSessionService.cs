public class UserSessionService {
    public bool IsLoggedIn { get; private set; } = false;
    public string Username { get; private set; }

    public void Login() {
        IsLoggedIn = true;
        Username = "John Doe"; // Replace with actual user logic
    }

    public void Logout() {
        IsLoggedIn = false;
        Username = null;
    }
}