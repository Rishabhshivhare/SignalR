using Microsoft.AspNet.SignalR;
using System.Threading;

namespace SignalR
 {  
  public class ChatHub : Hub  
  {  
     /// <summary>  
     /// Send the value to the server after every two seconds  
    /// </summary>  
     public void Send()
    {
            // for (int i = 0; i <= 100; i++)  
            //{  
            //      //"All" is dynamic, and broadcastMessage is the method that we'll  
            //     //create in JavaScript at client side.  
            //     Clients.All.broadcastMessage(i.ToString());

            //     Thread.Sleep(2000);  
            // }  
            string text1 = "rishabh";
            
            string clientId = Context.ConnectionId;
            
           
            Clients.All.broadcastMessage("Name:" + text1 + "    client-Id    " + clientId.Substring(0,7));
        }  
    }  
 }