//intance classi yaratmaq
using ClassIntro;

Phone phone = new Phone();

phone.Name = "iPhone 16";
phone.RAM = 16;
phone.CameraCount = 4;
phone.Weight = 300;
phone.Color = "Green";
phone.Brand = "Apple";
phone.Storage = 256;
phone.Price = 2000;

Command command = new Command();
Console.WriteLine(command.ChangePrice(phone.Price));