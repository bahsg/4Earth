using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Earth_Barbara_1708856
{
    public abstract class Login
    {
        private int id;
        public int ID { get { return id; } set { id = value; } }
        public string User_Name { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }


        public Login() { }

        public string ObterNome()

        {
            return ID.ToString() + Nome;
        }
        public string ObterUser_Name()

        {
            return ID.ToString() + User_Name;
        }
        public string ObterEmail()
        {
            return ID.ToString() + Email;
        }
        public string ObterSenha()
        {
            return ID.ToString() + Senha;
        }
    }
}
