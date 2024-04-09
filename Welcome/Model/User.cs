using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get ; set; }
        public UserRolesEnum Role { get; set; }
        public string email {  get; set; }
        public string facNumber {  get; set; }
        public virtual int id { get; set; }
        public DateTime expires { get; set; }

        

        private string ModifyPassword(string originalPassword)
        {
            char[] modifiedChars = new char[originalPassword.Length];

            for (int i = 0; i < originalPassword.Length; i++)
            {
                char originalChar = originalPassword[i];
                char modifiedChar = (char)(originalChar + 2);
                modifiedChars[i] = modifiedChar;
            }

            return new string(modifiedChars);
        }

    }
}
