namespace MyHabits
{
    public class UserRatingInFile : BasicUser
    {
        public UserRatingInFile(string name, string last) : base(name, last) 
        { 
        }

        public override void AddRating(float rating)
        {
            throw new NotImplementedException();    
        }

        public override void AddRating(int time)
        {
            throw new NotImplementedException();
        }

        public override void AddRating(string rating)
        {
            throw new NotImplementedException();
        }
    }
}
