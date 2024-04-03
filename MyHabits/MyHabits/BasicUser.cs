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

        public virtual void AddRating(string rating)
        {
            if(float.TryParse(rating, out float result))
            {
                this.AddRating(result);
            }
            else
            {
                throw new Exception("Nieprawidłowa wartość!");

            }
            
        }

        public abstract void AddTimeRating(int time);

    }
}
