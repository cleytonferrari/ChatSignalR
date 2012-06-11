using System;
using SignalR.Hubs;

namespace ChatSignalR.Hubs
{
    public class Chat : Hub
    {
        //Deve ter um metodo EnviarMensagem no JavaScript
        public void EnviarMensagem(string mensagem)
        {
            mensagem = "<em>" + DateTime.Now.ToString("HH:mm:ss") + "h</em> " + mensagem;

            //Chama um metodo implementado no cliente via JavaScritp
            Clients.adicionarMensagem(mensagem);
        }
    }
}