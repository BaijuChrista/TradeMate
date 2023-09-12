using System;
using SC.Data;
using System.Collections.Generic;
using System.Text;
using SC.Repository;
using SC.Service.Interface;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace SC.Service.Concrete
{
    public class UserService : IUserService
    {
        private ApplicationContext _context;
        private DbSet<ApplicationUser> entities;
        public UserService(ApplicationContext context)
        {

            this._context = context;
            entities = context.Set<ApplicationUser>();
        }

        public ApplicationUser Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            var user = entities.AsQueryable().Include(x=>x.UserType).Where(x => x.Username == username).FirstOrDefault();

            // check if username exists
            if (user == null)
                return null;

            // check if password is correct
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;

            // authentication successful
            return user;
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return _context.ApplicationUser;
        }

        public ApplicationUser GetById(long id)
        {
            return _context.ApplicationUser.Find(id);
        }

        public ApplicationUser Create(ApplicationUser user, string password)
        {
            // validation
            try
            {
                if (string.IsNullOrWhiteSpace(password))
                    throw new AppException("Password is required");

                if (_context.ApplicationUser.Any(x => x.Username == user.Username))
                    throw new AppException("Username \"" + user.Username + "\" is already taken");

                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(password, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;

                _context.ApplicationUser.Add(user);
                _context.SaveChanges();

                return user;
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\inetpub\wwwroot\TradeMateSite\Error.txt", ex.InnerException.ToString());
                throw ex;
            }
        }

        public void Update(ApplicationUser userParam, string password = null)
        {
            var user = _context.ApplicationUser.Find(userParam.Id);

            if (user == null)
                throw new AppException("User not found");

            if (userParam.Username != user.Username)
            {
                // username has changed so check if the new username is already taken
                if (_context.ApplicationUser.Any(x => x.Username == userParam.Username))
                    throw new AppException("Username " + userParam.Username + " is already taken");
            }

            // update user properties
            user.Username = userParam.Username;

            // update password if it was entered
            if (!string.IsNullOrWhiteSpace(password))
            {
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(password, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
            }

            _context.ApplicationUser.Update(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.ApplicationUser.Find(id);
            if (user != null)
            {
                _context.ApplicationUser.Remove(user);
                _context.SaveChanges();
            }
        }

        // private helper methods

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }
    }


    public class AppException : Exception
    {
        public AppException() : base() { }

        public AppException(string message) : base(message) { }

        public AppException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
