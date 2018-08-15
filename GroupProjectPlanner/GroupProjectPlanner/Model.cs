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
        string basePath, usersPath, metadataPath;
        int maxId = 0;
        const string end = @"/-----\END/-----\";

        public Model()
        {
            basePath = Directory.GetCurrentDirectory() + @"\configs";
            //metadataPath = basePath + @"\metadata.txt";

            InitUsers();
            InitItems();
        }

        private void InitUsers()
        {
            users = new List<string>();
            usersPath = basePath + @"\users.txt";

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

        private void InitStage(string stage)
        {
            var stagePath = basePath + @"\" + stage + ".txt";
            if (!File.Exists(stagePath))
            {
                using (StreamWriter sw = File.AppendText(usersPath))
                {
                    sw.WriteLine(end);
                }
                return;
            }

            string[] lines = File.ReadAllLines(usersPath);
            int i = 0;
            var item = new List<string>();
            var info = new List<string>();

            foreach (string line in lines)
            {
                if (line == end)
                {
                    string desc = "";
                    for (int j = 0; j < info.Count - 1; j++)
                    {
                        desc += info[j] + Environment.NewLine;
                    }
                    desc += info[info.Count - 1];

                    int id = int.Parse(item[0]);
                    display[stage].Add(new Item(id, item[1], desc, item[3]));

                    if (id > maxId) maxId = id;

                    item.Clear();
                    info.Clear();
                    i = 0;
                    continue;
                }
                if (i <= 2)
                {
                    // id name owner
                    // 0  1    2
                    item.Add(line);
                    i++;
                    continue;
                }

                info.Add(line);
            }
        }

        private void InitItems()
        {
            display = new Dictionary<string, List<Item>>
            {
                { "defined", new List<Item>() }
            };
            //display.Add("defined", new List<Item>());
            //display.Add("defined", new List<Item>());
            //display.Add("defined", new List<Item>());

            InitStage("defined");



        }

        public List<Item> GetItems(string stage)
        {
            return display[stage];
        }

        public void AddItem(string stage, Item newItem)
        {
            display[stage].Add(newItem);
        }

        public void AddItem(string stage, string name, string info, string owner)
        {
            display[stage].Add(new Item(maxId, name, info, owner));
            maxId++;
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
