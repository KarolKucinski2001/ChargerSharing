using Sharing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sharing.Services
{
    public class loginService : ILoginService
    {
        List<UserModel> userList = new List<UserModel>();


        public loginService()
        {
            userList.Add(new UserModel { userName = "user1", password = "123456" }) ;  
            userList.Add(new UserModel { userName = "user2", password = "1234567" }) ;  
        
        }
        public bool login(string username, string password)
        {
            foreach(var user in userList) 
            {
                if(username==user.userName & password==user.password)
                {
                    return true;    
                }
            }
            return false;
        }
    }
}
