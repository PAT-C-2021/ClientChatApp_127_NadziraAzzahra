using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClientChatApp_20190140127_NadziraAzzahra
{
    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext context = new InstanceContext(new ClientCallback());
            ServiceReference1.ServiceCallbackClient server = new ServiceReference1.ServiceCallbackClient(context);

            Console.WriteLine("Enter username");
            string nama = Console.ReadLine();
            server.gabung(nama);

            Console.WriteLine("Kirim pesan");
            string pesan = Console.ReadLine();

            //memeriksa apakah pesannya null
            while (true)
            {
                if (!string.IsNullOrEmpty(pesan))
                    server.kirimPesan(pesan);
                Console.WriteLine("Kirim Pesan");
                pesan = Console.ReadLine();
            }
        }

        public class ClientCallback : ServiceReference1.IServiceCallback // sebagai context/channel
        {
            public void gabung(string username)
            {
                throw new NotImplementedException();
            }

            public Task gabungAsync(string username)
            {
                throw new NotImplementedException();
            }

            public void kirimPesan(string pesan)
            {
                throw new NotImplementedException();
            }

            public Task kirimPesanAsync(string pesan)
            {
                throw new NotImplementedException();
            }

            public void pesanKirim(string user, string pesan)
            {
                Console.WriteLine("{0}: {1}", user, pesan);
            }
        }
    }
}