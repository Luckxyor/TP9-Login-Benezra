using System.Data.SqlClient;
using Dapper;

namespace TP9_Login_Benezra.Models;

static class BD{
    private static string _connectionString="Server=localhost; DataBase=TPLogin; Trusted_Connection=True;";

    public static void AgregarUsuario(string UserName, string Email, string Contraseña){
        string sqlInsert="Insert into Usuario (UserName, Email, Contraseña) values (@pUserName, @pEmail, @pContraseña)";
        using (SqlConnection db=new SqlConnection(_connectionString)){
            db.Execute(sqlInsert, new{pUserName=UserName, pEmail=Email, pContraseña=Contraseña});
        }
    }

    public static bool InicioSesion(string UserOEmail, string Contraseña){
        Usuario usuario=null;
        bool SiExiste;
        string sqlInsert="EXEC VerificarUsuario @pUserOEmail, @pContraseña;";
        using (SqlConnection db=new SqlConnection(_connectionString)){
            usuario=db.QueryFirstOrDefault<Usuario>(sqlInsert, new{pUserOEmail=UserOEmail, pContraseña=Contraseña});
        }
        if (usuario==null){
            return SiExiste=false;
        }
        else{
            return SiExiste=true;
        }
    }

    public static void ActualizarContraseña(string UserOEmail, string Contraseña){
        string sqlInsert="";
        using (SqlConnection db=new SqlConnection(_connectionString)){
            db.Execute(sqlInsert, new{pUserName=UserOEmail, pEmail=UserOEmail, pContraseña=Contraseña});
        }
    }
}