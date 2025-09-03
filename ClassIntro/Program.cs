using ClassIntro;

var samsung = new Phone()
{
    Brand = "Samsung",
    Color = "Black",
    Name = "S22",
    Price = 2000,
    RAM = 16,
    Storage = 256,
    Weight = 300,
    CameraCount = 4
};

var lenovo = new Laptop()
{
    Brand = "Lenovo",
    Weight = 1400,
    Storage = 512,
    RAM = 32,
    Price = 2000,
    Color = "White",
    Name = "ThinkPad",
    FanCount = 3
};

var exception = new NotFoundException();
Console.WriteLine(exception.Message);