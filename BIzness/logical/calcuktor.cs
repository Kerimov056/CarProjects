using CarSej.Service;
using System.Security.Cryptography.X509Certificates;

namespace BIzness.logical;

public class calcuktor
{
    
    public double MaxDistance(Vhicle vhicle)
    {
        return (vhicle.FullFuel / vhicle.FuelPrice) * 100;  //full baknan nece km yol getmek olar.
    }
    public double MyGoDistance(Vhicle vhicle)
    {
        return (vhicle.OurFuel / vhicle.FuelPrice) * 100;  //bakimdaki benzinnen max nece klometir yol gede bilerem
    }
    public double GoDistance(Vhicle vhicle, double Distance)  //km verrem gede bilersen?
    {
        double a = MyGoDistance(vhicle);
        if (a > Distance)
        {
            Distance /= 100; 
            return (vhicle.FuelPrice * Distance);  //eger gede bilirse nece litre benzin'den geder.
        }
        else
        {
            Distance -= a;
            return (Distance * vhicle.FuelPrice) / 100; //gede bilmirse nece litre benzin lazimdir.
        }
    }
    public double EmptyFuel(Vhicle vhicle)
    {
        return vhicle.FullFuel - vhicle.OurFuel;  //bakdakaki bow yanacaq yeri.
    }
    public  double Zaprafka(int l,string fuelType)  //10 litir benzin benizinin tipine gore cem qiymeti.
    {
        double cost = 0;
        switch (fuelType)
        {
            case "AI98":
                cost = FuelType.AI98 * l;
                return cost;
            case "AI95":
                cost = FuelType.AI95 * l;
                return cost;
            case "AI92":
                cost = FuelType.AI92 * l;
                return cost;
            case "DISEL":
                cost = FuelType.AI92 * l;
                return cost;
                default: return cost;
        }
    }
}
