namespace MyHabits
{
    public abstract class BasicUser : IUser
    {
        public BasicUser(string userName, string userLast)
        {
            this.UserName = userName;
            this.UserLast = userLast;
        }

        public string UserName { get; set; }
        public string UserLast { get; set; }

        public abstract void AddRating(float rating);

        public abstract void AddRating(string rating);

        public abstract void AddRating(int time);
    }
}
