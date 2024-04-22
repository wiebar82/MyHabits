using System.Security.Cryptography.X509Certificates;

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
            if (float.TryParse(rating, out float result))
            {
                this.AddRating(result);
            }
            else
            {
                string ratingInSmallCharacter = rating.ToLower();
                switch (ratingInSmallCharacter)
                {
                    case "mini":
                        AddRating(1.75f);
                        break;
                    case "midi":
                        AddRating(3.5f);
                        break;
                    case "max":
                        AddRating(5.75f);
                        break;
                    default:
                        throw new Exception("Nieprawidłowa wartość!");
                }
            }

        }

    public abstract void AddTimeRating(int time);
    }
}

