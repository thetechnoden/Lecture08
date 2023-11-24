using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_03;

Console.WriteLine("Choose a product type: 1 - Smartphone, 2 - Laptop");

IProductFactory? productFactory = null;

switch (Console.ReadLine())
{
    case "1":
        productFactory = new SmartphoneFactory();
        break;
    case "2":
        productFactory = new LaptopFactory();
        break;
    default:
        Console.WriteLine("Invalid choice. Exiting program.");
        return;
}

var screen = productFactory.CreateScreen();
var processor = productFactory.CreateProcessor();
var camera = productFactory.CreateCamera();

Console.WriteLine("Product created with the following components:");
Console.WriteLine($"Screen: {screen.GetDescription()}");
Console.WriteLine($"Processor: {processor.GetDescription()}");
Console.WriteLine($"Camera: {camera.GetDescription()}");
