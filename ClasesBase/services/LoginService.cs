using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase.services
{
    public class LoginService
    {

        public static Usuario login(List<Usuario> usuarios, string username, string password) {
            Usuario userSearch = usuarios.FirstOrDefault(
                usu => 
                    username.Equals(usu.Usu_NombreUsuario) &&
                    password.Equals(usu.Usu_Password )
                    );

            return userSearch;
        
        }
    }
}
