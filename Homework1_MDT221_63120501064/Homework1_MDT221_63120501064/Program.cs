using System;
using System.Collections.Generic;

namespace Homework1_MDT221_63120501064
{
    class Program
    {
        static void Main(string[] args)
        {

            User JameWatson = new User("Jame Watson", "jame@gmail.com");

            Tshirt orderNO1 = new Tshirt("L ", "Red ", "BB ", 500.0f);
            Tshirt orderNO2 = new Tshirt("M ", "Black ", "GG ", 750.0f);
            Tshirt orderNO3 = new Tshirt("S ", "Blue", " HH ", 625.0f);

            Address JameAddress = new Address("131/75 Phutthamonthon Road ", "Nakornpathom ", "Zipcode 10180");

            ShoppingCart JameWatsonCart = new ShoppingCart();

            JameWatsonCart.addshirt(orderNO1);
            JameWatsonCart.addshirt(orderNO2);
            JameWatsonCart.addshirt(orderNO3);
            JameWatsonCart.addlocal(JameAddress);

            JameWatson.showname(JameWatson);
            JameWatsonCart.ShowAddress();
            JameWatsonCart.ShowOrder();
            JameWatsonCart.TotalCost();

        }
    }

    class Tshirt
    {
        public string size;
        public string colour;
        public string image;
        public float cost;

        public Tshirt(string valueSize, string valueColour, string valueImage, float valueCost)
        {
            size = valueSize;
            colour = valueColour;
            image = valueImage;
            cost = valueCost;
        }
    }

    class User
    {
        public string name;
        public string email;

        public User(string valueName, string valueEmail)
        {
            name = valueName;
            email = valueEmail;

        }

        public void showname(User name)
        {
            Console.WriteLine(name.name);
            Console.WriteLine(name.email);
        }

    }

    class Address
    {
        public string street;
        public string city;
        public string zipcode;

        public Address(string valueStreet, string valueCity, string valueZipcode)
        {
            street = valueStreet;
            city = valueCity;
            zipcode = valueZipcode;
        }
    }

    class ShoppingCart
    {
        public List<Tshirt> tshirts;
        public List<Address> addressorder;
        public ShoppingCart()
        {
            tshirts = new List<Tshirt>();
            addressorder = new List<Address>();
        }

        public void addshirt(Tshirt shirt)
        {
            tshirts.Add(shirt);
        }

        public void addlocal(Address local)
        {
            addressorder.Add(local);
        }

        public void ShowOrder()
        {
            foreach (Tshirt jamebuy in tshirts)
            {
                Console.Write(jamebuy.size);
                Console.Write(jamebuy.colour);
                Console.Write(jamebuy.image);
                Console.WriteLine(jamebuy.cost);
            }
        }

        public void ShowAddress()
        {
            foreach (Address jamehome in addressorder)
            {
                Console.Write(jamehome.street);
                Console.Write(jamehome.city);
                Console.WriteLine(jamehome.zipcode);
            }
        }

        public void TotalCost()
        {
            float TotalCost = 0.0f;

            foreach (Tshirt ordercost in tshirts)
            {
                TotalCost += ordercost.cost;
            }
            Console.WriteLine(TotalCost);
        }
    }
}
