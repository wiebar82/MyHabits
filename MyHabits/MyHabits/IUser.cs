namespace MyHabits
{
    public interface IUser
    {
        string UserName { get; }
        string UserLast { get; }

        void AddRating(float rating);
        void AddRating(string rating);
    }
}
