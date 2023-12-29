using System.Reflection.Metadata.Ecma335;
using tecnosor.automatization.instagram;

Console.WriteLine("Creando bot...");

var bot = new InstagramBot();
var listaUsers = new List<string>()
{
    "messi",
    "ibai",
    "demo"
};

const string postUrl = "https://www.instagram.com/p/ABCdefghi/";
const int totalIteraciones = 500;
const int esperaEntreUsuarios = 61000; // 61 segundos espera entre comentario de usuario
const int esperaInicial = 40000; // 40 segundos espera inicial

bot.IniciarSesion();

Thread.Sleep(esperaInicial);
for (int i = 0; i < totalIteraciones; i++)
{
    Console.WriteLine($"[{DateTime.Now}] COMIENZO - Iteracion {i} de {totalIteraciones}: ");
    procesarUsuarios(bot, listaUsers, postUrl, esperaEntreUsuarios);
    Console.WriteLine($"[{DateTime.Now}] FIN - Iteracion {i} de {totalIteraciones}: ");
}

void procesarUsuarios(InstagramBot bot, List<string> usuarios, string postUrl, int esperaEntreUsuarios)
{
    foreach (var item in usuarios)
    {
        bot.IgComment(postUrl, $"Hola @{item}, te interesa?");
        Thread.Sleep(esperaEntreUsuarios);
    }
}