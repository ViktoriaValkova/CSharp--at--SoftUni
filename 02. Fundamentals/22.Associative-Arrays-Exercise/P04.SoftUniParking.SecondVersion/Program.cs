using System.ComponentModel;
using System.Xml.Linq;
using System;

namespace P04.SoftUniParking.SecondVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();
            int cmdCnt = int.Parse(Console.ReadLine());
            for (int i = 0; i < cmdCnt; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string command = cmdArgs[0];
                string userName = cmdArgs[1];

                switch (command)
                {
                    case "register":
                        string licensePlate = cmdArgs[2];
                        User currentUser = new User(userName, licensePlate);

                        if (!users.ContainsKey(userName))
                        {
                            users[userName] = currentUser;
                            Console.WriteLine($"{currentUser.Name} registered {currentUser.LicensePlate} successfully");
                        }
                        else
                        {
                            User foundUser = users[currentUser.Name];
                            Console.WriteLine($"ERROR: already registered with plate number {foundUser.LicensePlate}");
                        }

                        break;
                    case "unregister":
                        if (users.ContainsKey(userName))
                        {
                            users.Remove(userName);
                            Console.WriteLine($"{userName} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }

                        break;
                }

            }
            foreach (User user in users.Values)
            {
                Console.WriteLine(user);
            }

        }
    }
    class User
    {
        public User(string name, string licensePlate)
        {
            Name = name;
            LicensePlate = licensePlate;
        }

        public string Name { get; set; }
        public string LicensePlate { get; set; }
        public override string ToString()
        {
            return $"{this.Name} => {this.LicensePlate}";
        }
    }
}