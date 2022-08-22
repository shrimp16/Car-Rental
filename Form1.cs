namespace Car_Rental;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
}

public class Car
{

    string plate;
    string brand;

    bool isRent = false;

    public Car(string brand, string plate){
        this.brand = brand;
        this.plate = plate;
    }

}
