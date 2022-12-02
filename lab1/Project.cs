using Lab1

namespace Lab1
{
    public class Project
    {
        private iLogger _logger;
        private iNotifier _notifier;
        private string _projectName;
        private User _admin;
        private List<User> _users;
        private List<Ticket> _tickets;

        public Ticket CreateTicket(string ticket, User owner)
        {
            var newTask = new Ticket(_logger, ticket, owner);
            _tickets.Add(newTicket);
            _notifier.Notify($"Received new ticket: {ticket}", owner);

            return newTicket;
        }

        public void AddUser(User user)
        {
            _users.Add(user);
            _notifier.Notify($"{user.Name} now in {project}", _admin);
        }

        public void AddUser(User user, iNotifier notifier)
        {
            _users.Add(user);
            notifier.Notify($"{user.Name} now in {project}", _admin);
        }

        public Project(iLogger logger, iNotifier notifier, string projectName, User admin)
        {
            _logger = logger;
            _notifier = notifier;
            _projectName = projectName;
            _admin = admin;
            _users = new List<User>();
            _tasks = new List<Task>();
        }
    }
}
