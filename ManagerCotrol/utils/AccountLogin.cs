using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCotrol.utils
{
    public class AccountLogin
    {
        private String userName;
        private String password;
        private String permissionKey;
 

        public AccountLogin()
        {
        }

        public AccountLogin(String uSER_NAME, String pASSWORD, String pERMISSION)
        {
            this.userName = uSER_NAME;
            this.password = pASSWORD;
            this.permissionKey = pERMISSION;
        }

        public String getUserName()
        {
            return userName;
        }
        public void setUserName(String userName)
        {
            this.userName = userName;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public String getPassword()
        {
            return password;
        }

        public void setKeyPermission(String key)
        {
            this.permissionKey = key;
        }

        public String getPermissionKey()
        {
            return permissionKey;
        }
    }
}
