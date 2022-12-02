using Lab1

namespace Lab1
{
    public class Ticket
    {
        private iLogger _logger;
        private string _state;
        private string _ticket;
        private User _owner;

        public void ChangeState(string state)
        {
            _state = state;
            _logger.Log($"{_owner.Name} changed ticket state {state}");
        }

        public void ChangeState(string state, User user)
        {
            _state = state;
            _logger.Log($"{user.Name} changed ticket state {state}");
        }

        public Ticket(iLogger logger, string task, User owner)
        {
            _logger = logger;
            _task = task;
            _owner = owner;
        }
    }
}
