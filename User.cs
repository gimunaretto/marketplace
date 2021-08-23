using System;

namespace ProjetoLetsCode2
{
    public class User : ISeller, IClient
    {
        public int id { get; set; }

        public string name { get; set; }

        public Address deliveryAddress { get; set; }

        public Address billingAddress { get; set; }

        public string user { get; set; }

        public bool isSeller { get; set; } = false;

        public bool isClient { get; set; } = false;

        public string password { get; set; }

        public DateTime birthDate { get; set; }

    }
}