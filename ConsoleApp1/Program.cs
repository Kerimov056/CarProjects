using BIzness.logical;
using CarSej.Service;

Vhicle car1 = new Vhicle("BMW", "E31", 90, 45, 15,"AI98");
Console.WriteLine(car1.Aboutss());
Console.WriteLine($"{car1.Id} Number car");

calcuktor c1= new calcuktor();
Console.WriteLine("MaxDistance:"+c1.MaxDistance(car1));
Console.WriteLine("MyGoDistance:"+c1.MyGoDistance(car1));
Console.WriteLine("GoDistance:" + c1.GoDistance(car1, 350));
Console.WriteLine("EmptyFuel:" + c1.EmptyFuel(car1));
Console.WriteLine("Fuel rasxod:" + c1.Zaprafka(10, "AI92"));

Console.WriteLine("---------------------------------------");

Vhicle car2 = new Vhicle("BMW", "E39", 90, 45, 15, "AI98");
Console.WriteLine($"{car2.Id} Number car");

