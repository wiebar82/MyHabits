using System;

namespace MyHabits
{
    public class UserRatingInFile : BasicUser
    {
        private const string fileName = "rating.txt";
        private const string fileTimeName = "time.txt";
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

        public override void AddTimeRating(int time)
        {
            if(time >= 10 &&  time <= 200)
            {
                using (var writer = File.AppendText(fileTimeName))
                {
                    writer.WriteLine(time);
                    if(RatingAdd != null)
                    {
                        RatingAdd(this, new EventArgs());
                    }
                }
            }
            else if (time >= 0 && time < 10)
            {
                Console.WriteLine("Za krótko dziś kodowałeś :(");
                Console.WriteLine();
            }
            else if (time > 200)
            {
                Console.WriteLine("Nie przesadasz! ;)");
                Console.WriteLine();
            }
            else
            {
                throw new Exception("Ocena nieprawidłowa!");
            }
        }

        //public override void AddRating(string rating)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
