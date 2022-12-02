using Lab1

namespace Lab1
{
    public class Demo
    {
        public void Run()
        {
            var logger = new Logger();
            var emailNotifier = new EmailNotifier();

            var user1 = new User("User1");
            var user2 = new User("User2");
            var user3 = new User("User3");
            var user4 = new User("User4");

            var Project1 = new Project(logger, emailNotifier, "Ticket1", user1);
            var Ticket1 = Project1.CreateTicket("Ticket1", user2);
            var Ticket2 = Project1.CreateTicket("Ticket2", user4);

            Project1.AddUser(user5);

            Ticket1.ChangeState("Started");
            Ticket2.ChangeState("Verification", user1);
            Ticket1.ChangeState("Accepted", user1);
        }
    }
}
