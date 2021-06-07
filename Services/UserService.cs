using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BankAPI.Dto;
using BankAPI.Model;

namespace BankAPI.Services
{
    public class UserService
    {
        private readonly BankContext _context;

        public UserService(BankContext context)
        {
            _context = context;
        }
        public void Register(RegisterDto register)
        {
            var user = new User
            {
                Login = register.Name,
                Password = GetHash(register.Password)
            };
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public UsernameDto UserExists()
        {

            if (!_context.Users.Any())
            {
                return null;
            }

            var username = _context.Users.Single().Login;
            var id = _context.Users.Single().Id;
            return new UsernameDto
            {
                Login = username,
                Id = id
                
            };
        }

        public BalanceDto Balance()
        {
            if (!_context.Users.Any())
            {
                return null;
            }

            var balance = _context.Users.Single().Balance;
            var id = _context.Users.Single().Id;
            var login = _context.Users.Single().Login;
            return new BalanceDto()
            {
                Balance = balance,
                Id=id,
                Login = login
            };
        }

        public UserDto Login(LoginDto login)
        {
            var hash = GetHash(login.Password);
            
            if (!_context.Users.Any())
            {
                return null;
            }

            var user = _context.Users.Single();
            if (user.Password == hash)
            {
                return new UserDto
                {
                    Login = user.Login,
                    Token = "123456789"
                };
            }

            return null;

        }

        private string GetHash(string password)
        {
            var algorythm = SHA256.Create();

            StringBuilder sb = new StringBuilder();
            foreach (var b in algorythm.ComputeHash(Encoding.UTF8.GetBytes(password)))
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
