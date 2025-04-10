using _14_Day.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Day.user
{
    public interface IProfile
    {
        UserModel? UserPublicProfile(int uid);
        bool UserLogout(int uid);
    }
}
