using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.models
{
    public class User
    {
        public User() { }
        
        public string username { set; get; }
        public int id { set; get; }
        
        public Boolean Isvalid(string name,int pass)

        {
            if (name == username && pass == id)
                return true;
            else
                return false;

        }
        

        public User(string username, int id )
        {
            this.username = username;
            this.id = id;
        }
    }
}
