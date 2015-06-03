using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;


namespace WebApplication3
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }


    public class Venda : Hub
    {
        public void NovaVenda(string produto)
        {
            var connectId= Context.ConnectionId;

            Clients.AllExcept(connectId).AlertarNovaVenda(produto);
        }
    }
}
