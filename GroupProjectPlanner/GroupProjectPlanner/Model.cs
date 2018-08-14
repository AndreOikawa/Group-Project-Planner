using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectPlanner
{
    class Model
    {
        List<string> users;
        Dictionary<string, List<Item>> display;
        string usersPath;

        public Model()
        {
            InitUsers();
            InitItems();
        }

        private void InitUsers()
        {
            users = new List<string>();
            usersPath = Directory.GetCurrentDirectory() + @"\configs\users.txt";

            if (!File.Exists(usersPath))
            {
                using (StreamWriter sw = File.AppendText(usersPath))
                {
                    sw.WriteLine("Anonymous");
                }
            }

            string[] lines = File.ReadAllLines(usersPath);
            foreach (string line in lines)
            {
                users.Add(line);
            }

            if (!users.Contains("Anonymous"))
            {
                using (StreamWriter sw = File.AppendText(usersPath))
                {
                    sw.WriteLine("Anonymous");
                }
                users.Add("Anonymous");
            }
        }

        private void InitItems()
        {
            display = new Dictionary<string, List<Item>>();

        }

        public List<Item> GetItems(string stage)
        {
            return display[stage];
        }

        public void AddItem(string stage, Item newItem)
        {
            display[stage].Add(newItem);
        }

        public List<string> GetUsers()
        {
            return users;
        }

        public bool AddUser(string name)
        {
            if (users.Contains(name, StringComparer.OrdinalIgnoreCase))
            {
                return false;
            }

            users.Add(name);

            if (!users.Contains("Anonymous"))
            {
                users.Add("Anonymous");
            }

            if (!File.Exists(usersPath))
            {
                using (StreamWriter sw = File.AppendText(usersPath))
                {
                    foreach (var user in users)
                    {
                        sw.WriteLine(user);
                    }
                }
            }
            else
            {
                string[] lines = File.ReadAllLines(usersPath);
                var missingUsers = users.Except(lines);
                if (missingUsers.Count() > 0)
                    using (StreamWriter sw = File.AppendText(usersPath))
                    {
                        foreach (string user in missingUsers)
                        {
                            sw.WriteLine(user);
                        }
                    }
            }
            return true;
        }

        public void RemoveUser(string name)
        {
            users.Remove(name);
            File.Delete(usersPath);
            using (StreamWriter sw = File.AppendText(usersPath))
            {
                foreach (string user in users)
                {
                    sw.WriteLine(user);
                }
            }
        }
    }
}
