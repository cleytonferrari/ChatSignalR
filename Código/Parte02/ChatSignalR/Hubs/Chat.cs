using System;
using SignalR.Hubs;

namespace ChatSignalR.Hubs
{
    public class Chat : Hub
    {
        //Deve ter um metodo EnviarMensagem no JavaScript
        public void EnviarMensagem(string mensagem, string grupo)
        {
            mensagem = "<em>" + DateTime.Now.ToString("HH:mm:ss") + "h [" + grupo + "]</em> " + mensagem;

            //Groups.Add(Context.ConnectionId, grupo);

            //Chama um metodo implementado no cliente via JavaScritp
            Clients[grupo].adicionarMensagem(mensagem);

            //Caller.adicionarMensagem("Mensagem Enviada");


        }

        public void AdicionaGrupo(string grupo)
        {
            Caller.adicionarMensagem("Entrou no grupo: " + grupo);
            Groups.Add(Context.ConnectionId, grupo);
        }
        public void RemoveGrupo(string grupo)
        {
            Caller.adicionarMensagem("Saiu do grupo:" + grupo);
            Groups.Remove(Context.ConnectionId, grupo);
        }
    }
}