using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal_Giris.NewPerson
{
    public class Users
    {
        private List<StructPerson> users = new List<StructPerson>();

        public void AddUser(StructPerson newUser)
        {
            users.Add(newUser);
        }

        public void RemoveUser(StructPerson user)
        {
            users.Remove(user);
        }

        public List<StructPerson> GetUsers()
        {
            return users;
        }
    }
}
