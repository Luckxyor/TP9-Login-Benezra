using System.Data.SqlClient;
using Dapper;

namespace TP9_Login_Benezra.Models;

static class BD{
    private static string _connectionString="Server=localhost; DataBase=TPLogin; Trusted_Connection=True;";

    public static void AgregarUsuario(string UserName, string Email, String Contraseña){
        string sqlInsert="Insert into Usuario (UserName, Email, Contraseña) values (@pUserName, @pEmail, @pContraseña)";
        using (SqlConnection db=new SqlConnection(_connectionString)){
            db.Execute(sqlInsert, new{pUserName=UserName, pEmail=Email, pContraseña=Contraseña});
        }
    }

    public static bool InicioSesion(string UserOEmail, String Contraseña){
        string sqlInsert="RETURNS BIT; if exist(Select * from Usuario where (UserName=@pUserOEmail or Email=@ppUserOEmail) and Contraseña=@pContraseña) begin return 1; else return 0; END";
        using (SqlConnection db=new SqlConnection(_connectionString)){
            bool Existe=db.Execute(sqlInsert, new{pUserOEmail=UserOEmail, pContraseña=Contraseña});
        }
        return Existe;
    }
}