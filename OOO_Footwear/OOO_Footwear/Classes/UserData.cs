using System;
using System.Linq;

namespace OOO_Footwear.Classes
{
    public class UserData
    {
        private bool _IsEnter;

        private int? _userRole;
        private String _userName;

        private String _userLogin;
        private String _userSecret;

        private String _userSecondName;
        private String _userFirstName;

        public int UserId { get; set; }

        public int? UserRole
        {
            get => _userRole;
        }

        public string UserName
        {
            get => _userName;
        }

        public string UserSecondName
        {
            get => _userSecondName;
        }

        public string UserFirstName
        {
            get => _userFirstName;
        }

        private string UserPassword
        {
            get
            {
                return _userSecret;
            }
            set
            {
                _userSecret = value;
            }
        }

        public UserData() 
        {
          
        }

        public UserData (string login) : this ()
        { 
           _userLogin = login;  
        }
        
        public UserData(String login, String secret) : this(login)
        {
            _userSecret = secret;

            if (!login.Equals("") && !secret.Equals(""))
            {
                UserVerification(_userLogin, _userSecret);
            }
        }

        public bool IsEnter()
        {
            if (_userRole == null)
            {
                _IsEnter = false;
            }
            else
            {
                _IsEnter = true;
            }
             
            return _IsEnter;
        }

        private void UserVerification(string userLogin, string userSecret)
        {
            try
            {
                _userRole = SQLDatabaseHelper.DatabaseContext.User?
                    .Where(x => x.UserLogin == userLogin && x.UserPassword == userSecret).FirstOrDefault()?.UserRole;

                if (_userRole == null) return;

                _userName = SQLDatabaseHelper.DatabaseContext.Role?
                    .Where(x => x.RoleId == _userRole).FirstOrDefault()?.RoleName;

                _userFirstName = SQLDatabaseHelper.DatabaseContext.User?
                   .Where(x => x.UserLogin == userLogin && x.UserPassword == userSecret).FirstOrDefault()?.UserFirstName;          
                
                _userSecondName = SQLDatabaseHelper.DatabaseContext.User?
                   .Where(x => x.UserLogin == userLogin && x.UserPassword == userSecret).FirstOrDefault()?.UserSecondName;

            }
            catch (Exception)
            {
                
            }
        }

        public void Guest()
        {
            _userRole = 4;
            _userName = "Гость";

            _userSecondName = "Гость";
            _userFirstName = String.Empty;
        }
    }
}
