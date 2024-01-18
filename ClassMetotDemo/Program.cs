using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MusteriManager newOp = new MusteriManager();
                ;
                Console.WriteLine("Yapmak istediğin komutu gir <Ekle(e) / Silme(s) / Listele(l)> ");
                char command = (Console.ReadLine()).ToCharArray()[0];
                if (command == 'e' || command == 's' || command == 'l')
                {
                    //Console.WriteLine("Yapmak istediğin komutu gir <Ekle(e) / Silme(s) / Listele(l)> ");
                    if (command != 's' || command != 'l')
                    {
                        Console.WriteLine("Kullanıcı sayısını gir>  ");
                        string client_number = Console.ReadLine();
                        int num_cli = Convert.ToInt16(client_number);
                        Musteri[] clients = new Musteri[num_cli];
                        for (int i = 0; i < num_cli; i++)
                        {
                            clients = newOp.Ekle(num_cli);//, clients[0]);

                        }
                        if ( command == 's')
                        {
                            Console.WriteLine("Silmek istediğin ID numarasını gir> ");
                            int Id = Convert.ToInt16(Console.ReadLine());
                            clients = newOp.Sil(clients, num_cli, Id);
                        }
                        else if (command == 'l')
                            newOp.Listele(clients, num_cli);
                    }

                    }
                }
            }
        }
    }



