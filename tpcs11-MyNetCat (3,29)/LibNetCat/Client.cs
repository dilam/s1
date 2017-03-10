#region Usings

using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

#endregion

namespace LibNetCat
{
    public class Client
    {
        #region Variables Privées
        /// <summary>
        /// Le socket représentant la connexion
        /// </summary>
        private readonly Socket _sock;

        /// <summary>
        /// Buffer de 2 octets dans lequel on reçoit les instructions
        /// </summary>
        private byte[] _messageType;

        /// <summary>
        /// Buffer qui nous permet de recevoir les messages
        /// </summary>
        private byte[] _content;

        #endregion

        #region Events

        /// <summary>
        /// Event envoyé en cas de déconnection.
        /// </summary>
        public event EventHandler Disconnected;

        /// <summary>
        /// Event envoyé en cas de message reçu.
        /// </summary>
        public event EventHandler<MessageEvent> MessageReceived;

        /// <summary>
        /// Parle de lui même
        /// </summary>
        public event EventHandler PongEvent;

        /// <summary>
        /// Permet de suivre la progression d'un transfert de fichier
        /// </summary>
        public event EventHandler<TransfertEvent> TransfertProgress;

        #endregion

        #region Initialization

        /// <summary>
        /// L'initialisation systématique est ici.
        /// </summary>
        private void Initialize()
        {
            _messageType = new byte[sizeof(ushort)];
            _sock.BeginReceive(_messageType, 0, _messageType.Length, SocketFlags.None, ReceiveDatas, _sock);
        }

        /// <summary>
        /// Constructeur appelé lorsque le Socket est déjà créé.
        /// </summary>
        /// <param name="sock">Socket utilisé pour la communication.</param>
        public Client(Socket sock)
        {
            _sock = sock;
            Initialize();
        }

        /// <summary>
        /// Ce constructeur créé un socket et le connecte.
        /// </summary>
        /// <param name="ip">L'addresse IP de connection</param>
        /// <param name="port">Port de connection.</param>
        public Client(IPAddress ip, int port = 4242)
        {
            _sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try {
                _sock.Connect(ip, port);
            }            catch (Exception e)
            {
                Console.WriteLine("Erreur de connexion :" + e.Message);
            }

            Initialize();
        }

        #endregion

        #region Méthodes Privées

        /// <summary>
        /// Cette méthode récupère les instructions et dispatche vers des méthodes adéquoites.
        /// </summary>
        private void ReceiveDatas(IAsyncResult ar)
        {
            if (ar.IsCompleted)
            {
                try
                {
                    if ((Instructions)BitConverter.ToUInt16(_messageType, 0) == Instructions.Ping)
                        _sock.Send(BitConverter.GetBytes((ushort)Instructions.Pong));

                    else if ((Instructions)BitConverter.ToUInt16(_messageType, 0) == Instructions.BasicMessage)
                        _sock.Send(BitConverter.GetBytes((ushort)Instructions.BasicMessage));

                    else if ((Instructions)BitConverter.ToUInt16(_messageType, 0) == Instructions.FileTransfert)
                        _sock.Send(BitConverter.GetBytes((ushort)Instructions.FileTransfert));

                    else if ((Instructions)BitConverter.ToUInt16(_messageType, 0) == Instructions.Pong)
                        _sock.Send(BitConverter.GetBytes((ushort)Instructions.Ping));

                    else if ((Instructions)BitConverter.ToUInt16(_messageType, 0) == Instructions.Disconnect)
                        _sock.Send(BitConverter.GetBytes((ushort)Instructions.Disconnect));
                }
                catch (SocketException e)
                {
                    if (e.NativeErrorCode != 10054)
                        throw e;
                    if (Disconnected != null)
                        Disconnected(this, EventArgs.Empty);
                }
                catch (ObjectDisposedException)
                {
                }
            }
        }

        /// <summary>
        /// Cette méthode récupère un fichier et l'écrit sur le dique dur.
        /// </summary>
        private void ReceiveFile()
        {
            throw new NotImplementedException("Fixme");
        }

        /// <summary>
        /// Cette méthode récupère un message.
        /// </summary>
        private void ReceiveBasicMessage(IAsyncResult ar)
        {
            throw new NotImplementedException("Fixme");
        }

        /// <summary>
        /// Cette méthode envoie de manière asynchrone un buffer.
        /// </summary>
        /// <param name="buf">Le buffer à envoyer</param>
        private void SendData(byte[] buf)
        {
            throw new NotImplementedException("Fixme");
        }

        #endregion

        #region Méthodes publiques

        /// <summary>
        /// Cette méthode envoie un fichier au correspondant.
        /// </summary>
        /// <param name="filename">Nom du fichier à ouvrir.</param>
        public void SendFile(string filename)
        {
            throw new NotImplementedException("Fixme");
            /**
            ** This Should prove usefull :)
            ** filename = Path.GetFileName(filename);
            */
        }

        /// <summary>
        /// Cette méthode déconnecte le client.
        /// </summary>
        public void Disconnect()
        {
            throw new NotImplementedException("Fixme");
        }

        /// <summary>
        /// Envoie un message.
        /// </summary>
        /// <param name="msg">Message à envoyer</param>
        public void SendMessage(string msg)
        {
            throw new NotImplementedException("Fixme");
        }

        /// <summary>
        /// Envoie une requette Ping.
        /// </summary>
        public void Ping()
        {
            byte data = (byte)Instructions.Ping;
            byte[] ping = new byte[] { data };
            SendData(ping);
        }

        #endregion
    }
}
