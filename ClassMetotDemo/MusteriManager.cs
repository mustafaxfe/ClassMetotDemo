using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        // Add 
        public Musteri[] Ekle(int num_cli)//, Musteri clients)
        {
   
            Musteri[] clients = new Musteri[num_cli];

            for (int i = 0; i <= num_cli-1; i++)
            {
                clients[i] = new Musteri();
                //[] clients = new Musteri[num_cli];
                Console.WriteLine("Müşterinin ID numarasını gir> ");
                clients[i].Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(clients[i].Id);
                Console.WriteLine("Müşterinin ismini gir> ");
                clients[i].Ad = Console.ReadLine();
                Console.WriteLine("Müşterinin soy ismini gir> ");
                clients[i].Soyad = Console.ReadLine();
                Console.WriteLine(clients[0].Soyad);
                Console.WriteLine("Müşterinin bakiyesini gir> ");
                clients[i].Bakiye = Convert.ToDouble(Console.ReadLine());
            }
                
            Console.WriteLine("Eklenecek müşteri kalmadı");
            return clients;
        }
        public Musteri[] Sil(Musteri[] client, int num_cli,int Id)
        {
            for(int i = 0; i<num_cli;i++)
            {
                if ( client[i].Id == Id)
                    Console.WriteLine("Id = " + client[i].Id + " Adı = " + 
                        client[i].Ad + " Soyadı = " + client[i].Soyad + " müşteri silinmiştir.");
            }
            return client;
        }
        public void Listele(Musteri[] client, int num_cli)
        {
            for (int i = 0; i < num_cli; i++)
            {
                Console.WriteLine("ID = " + client[i].Id + " Adı: " +
                    client[i].Ad + " Soyadı: " + client[i].Soyad +
                    " olan kullanıcın bakiyesi: " + client[i].Bakiye);
            }
            
        }
    }
}
