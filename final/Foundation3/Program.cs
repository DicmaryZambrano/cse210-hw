using System;
using Foundation3;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("4 Calle la Naranjal, Casa 258", "Trujillo", "Trujillo", "Venezuela");
        Address address2 = new Address("495 Grove Street, Michael's Park", "New York", "NY", "USA");
        Address address3 = new Address("Churchill-laan 266/III", "AMSTERDAM", "GA", "Netherlands");

        Reception reception = new Reception("Weddiing Party","This is a reception for the wedding party of Jonhn Doe and Katherine Smith","4/1/2023","11:00 AM",address1,"jdamely1999@email.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Michael's Birthday Party","This is an invitation to Michael's birthday party, he is turning 9 years old","3/30/2023","2:00 PM",address2,"Sunny with clear sky");
        Lecture lecture = new Lecture("Jesus Christ and the Everlasting Gospel","This is a talk were we will learn everything about the everlasting gospel of Jesus Christ","4/6/2023","8:00 AM",address3,"Maria Chasin","100 students");

        List<Event> events = new List<Event>{
            reception,
            outdoorGathering,
            lecture
        };

        foreach (Event indEvent in events)
        {
            Console.WriteLine(new string('*',100));
            Console.WriteLine();
            Console.WriteLine(indEvent.getFullDetails());
            Console.WriteLine();
            Console.WriteLine(new string('-',100));
            Console.WriteLine();
            Console.WriteLine(indEvent.getShortDetails());
            Console.WriteLine();
            Console.WriteLine(new string('-',100));
            Console.WriteLine();
            Console.WriteLine(indEvent.getStandadDetails());
            Console.WriteLine();
        }
    }   
}