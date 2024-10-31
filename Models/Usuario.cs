namespace TP9_Login_Benezra.Models;

class Usuario{
    public int IdUsuario{ get; set; }
    public string UserName { get; set; }
    public string Contraseña { get; set; }

    public string Email { get; set; }

    public Usuario(){
    }
}