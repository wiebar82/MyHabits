using System;

namespace MyHabits
{
    public class UserRatingInFile : BasicUser
    {
        private const string fileName = "rating.txt";
        public UserRatingInFile(string name, string last) : base(name, last) 
        { 
        }

        public delegate void RatingAddDelegate(object sender, EventArgs e);
        public event RatingAddDelegate RatingAdd;
        public override void AddRating(float rating)
        {
            if(rating >= 0 && rating <= 6)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(rating);
                    if(RatingAdd != null) 
                    {
                        RatingAdd(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("Ocena nieprawidłowa!");
            }
        }

        public override void AddRating(int time)
        {
            throw new NotImplementedException();
        }

        //public override void AddRating(string rating)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
