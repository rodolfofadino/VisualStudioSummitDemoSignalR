using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using WebApplication2;


namespace WebApplication2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }


    public class Chat : Hub
    {
        public void EnviarMensagem(string mensagem, string nome)
        {
            Clients.All.TransmitirMensagem(mensagem, nome);
        }
    }
}
