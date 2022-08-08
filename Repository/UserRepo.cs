using Microsoft.IdentityModel.Tokens;
using ReturnOrderMgmtSystemV1.Models;
using ReturnOrderMgmtSystemV1.Models.DTOs;
using ReturnOrderMgmtSystemV1.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace ReturnOrderMgmtSystemV1.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly ApplicationDbContext _db;

        public UserRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        public int addUser(UserDto UserData)
        {
            try
            {
                if (userExist(UserData.UserName))
                {
                    return -1;
                }

                User user = new User();
                user.UserName = UserData.UserName;
                user.Password = UserData.Password;
                user.Name = UserData.Name;
                user.PhNumber = UserData.PhNumber;

                _db.user.Add(user);

                int status = _db.SaveChanges();

                return status;
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public UserDto authenticate(string username, string password)
        {
            UserDto user = new UserDto();
            User userData = new User();
            try
            {
                if (!userExist(username))
                {
                    return null;
                }
                userData = _db.user.FirstOrDefault(x => x.UserName.ToLower() == username.ToLower() && x.Password == password);
                if (userData != null)
                {
                    //user.UserName = userData.UserName;
                    user.Name = userData.Name;
                    user.PhNumber = userData.PhNumber;
                    user.token = GetJwtTokenString();

                }
                return user;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool userExist(string username)
        {
            try
            {
                var user = _db.user.FirstOrDefault(x => x.UserName == username);
                if (user == null)
                    return false;

                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private static string GetJwtTokenString()
        {
            try
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Secret key string"));
                var SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var tokenOptions = new JwtSecurityToken(
                    
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: SigningCredentials
                    );

                string tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                return tokenString;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
