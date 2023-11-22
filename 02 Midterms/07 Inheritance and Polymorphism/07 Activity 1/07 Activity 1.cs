namespace UserNamespace
{
    abstract class User
    {
        private string user_id;
        protected string user_password;
        // = = = = = // = = = = = // = = = = = // = = = = = // = = = = = //
        public User(string id, string pass)
        {
            user_id = id;
            user_password = pass;
        }
        public bool verifyLogin(string id, string pass)
        {
            if (...)
            {
                return true;
            }
            return false;
        }
        public abstract void updatePassword(string newPassword);
    }

    class Administrator : User
    {
        private string admin_name;
        // = = = = = // = = = = = // = = = = = // = = = = = // = = = = = //
        public Administrator(string name, string id, string pass)
        {
            admin_name = name;
            user_id = id;
            user_password = pass;
        }
        public override void updatePassword(string newPassword)
        {
            // code here
        }
        public void updateAdminName(string name)
        {
            // code here
        }
    }
}