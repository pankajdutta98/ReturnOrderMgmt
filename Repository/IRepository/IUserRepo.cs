using ReturnOrderMgmtSystemV1.Models.DTOs;

namespace ReturnOrderMgmtSystemV1.Repository.IRepository
{
    public interface IUserRepo
    {
        public bool userExist(string username);
        public int addUser(UserDto UserData);
        public UserDto authenticate(string username, string password);                
    }
}
