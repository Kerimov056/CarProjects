namespace CarSej.Service;

public class Vhicle:ConstDeyerler
{
    public string Brend { get; set; } //model
    public string Model { get; set; } //marka
    public double FullFuel { get; set; } //bak'in tutumu
    public double OurFuel { get; set; } //bakdaki benzin
    public int FuelPrice { get; set; } //100'e ne qeder icir
    public string fueltype { get; set; }  //Benzin Novu


    public Vhicle(
        string Brend,
        string Model,
        double FullFuel,
        double OurFuel,
        int FuelPrice,
        string fueltype)
    {
        this.Brend = Brend;
        this.Model = Model;
        this.FullFuel = FullFuel;
        this.OurFuel = OurFuel;
        this.FuelPrice = FuelPrice;
        this.fueltype=fueltype;
    }
    public string Aboutss()
    {
        return $"Marka:{Brend} \nModel:{Model} \nOur Fuel:{OurFuel} \nFullFuel:{FullFuel} \nFuelPRice:{FuelPrice} \nFuelType:{fueltype}";
    }
}
