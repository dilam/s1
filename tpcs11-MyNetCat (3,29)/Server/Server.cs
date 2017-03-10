#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using LibNetCat;

#endregion

namespace Server
{
    class Server
    {
        #region Variables Privées

        private readonly Socket _sock;
        private readonly List<Client> _clients;

        #endregion

        #region Initialization

        public Server(int port)
        {
            throw new NotImplementedException("Fixme");
        }

        #endregion

        #region Méthodes Privées

        /// <summary>
        /// Handle a new connexion.
        /// </summary>
        private void ClienConnected(IAsyncResult ar)
        {
            throw new NotImplementedException("Fixme");
        }

        /// <summary>
        /// Handle when a client has exited.
        /// </summary>
        private void ClientQuit(object sender, EventArgs e)
        {
            throw new NotImplementedException("Fixme");
        }

        /// <summary>
        /// Prints a message received
        /// </summary>
        private void MessageReceived(object sender, MessageEvent msg)
        {
            Console.WriteLine(msg.Content);
        }

        /// <summary>
        /// Prints the progress of a file transfert
        /// </summary>
        private void FileProgress(object sender, TransfertEvent tr)
        {
            throw new NotImplementedException("Fixme");
        }

        #endregion

        #region Méthodes publiques

        /// <summary>
        /// Sends a message to all the clients.
        /// </summary>
        /// <param name="msg">Content of the message</param>
        public void SendMessage(string msg)
        {
            throw new NotImplementedException("Fixme");
        }

        /// <summary>
        /// Disconnect all clients
        /// </summary>
        public void Disconnect()
        {
            throw new NotImplementedException("Fixme");
        }

        #endregion
    }
}
