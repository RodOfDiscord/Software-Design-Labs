namespace Authenticator
{
    public sealed class Authenticator
    {
        public Dictionary<int,string> Users { get; private set; }
        private static Authenticator? instance;
        private static object _lock = new();

        private Authenticator() 
        {
            Users = [];
        }

        public static Authenticator GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    instance ??= new Authenticator();
                }
            }
            return instance;
        }

        public void AddUser(int id, string username)
        {
            Users.TryAdd(id, username);
        }

        public void RemoveUser(int id)
        {
            Users.Remove(id);
        }

        public string GetUsers()
        {
            string res = string.Empty;
            foreach(KeyValuePair<int,string> pair in Users)
            {
                res += $"{pair.Key} - {pair.Value}\n";
            }
            return res;
        }
    }
}
