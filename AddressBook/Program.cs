namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome To Address Book Program");
            Console.WriteLine("Enter FirstName,Last name,Address,City,State,Zip,Phone Number,Email\n");
            //for (int i = 0; i < 5; i++)
            //{
            CreateContact contact = new CreateContact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Convert.ToDouble(Console.ReadLine()),
                PhoneNumber = Convert.ToDouble(Console.ReadLine()),
                EmailId = Console.ReadLine(),
            };

            Console.WriteLine("FirstName: " + contact.FirstName + "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n" + "Zip: " + contact.Zip + "\n" + "PhoneNumber: " + contact.PhoneNumber + "\n" + "Email: " + contact.EmailId);

            //}
        }
    }
}