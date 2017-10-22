using System;
namespace TruecaApp.Classes
{
    public class User
    {
        #region attributes
        #endregion

        #region Properties
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string BirthDate
        {
            get;
            set;
        }

        public string ProfilePicture
        {
            get;
            set;
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }

        public string FullPicture
        {
            get
            {
                if(string.IsNullOrEmpty(ProfilePicture))
                {
                    return "icons8-User Male Filled-100.png";
                }
                return ProfilePicture;
            }
        }
   
        #endregion
        public User()
        {
        }
    }
}
