using System;
using SOLIDPrinciples.SRP;
using SOLIDPrinciples.OCP;
using SOLIDPrinciples.LSP;
using SOLIDPrinciples.ISP;
using SOLIDPrinciples.DIP;

// SRP - Single Responsibility Principle Demo
Console.WriteLine("========== SRP Demo (Single Responsibility Principle) ==========");
var invoice = new Invoice { InvoiceId = "INV001", CustomerName = "John Doe" };
invoice.AddItem("Laptop", 999.99m, 1);
invoice.AddItem("Mouse", 49.99m, 2);

var printer = new InvoicePrinter();
printer.Print(invoice);

// OCP - Open/Closed Principle Demo
Console.WriteLine("\n========== OCP Demo (Open/Closed Principle) ==========");
Shape circle = new Circle(5);
Shape rectangle = new Rectangle(4, 6);

circle.DisplayArea();
rectangle.DisplayArea();

// LSP - Liskov Substitution Principle Demo
Console.WriteLine("\n========== LSP Demo (Liskov Substitution Principle) ==========");
Bird sparrow = new Sparrow("Tweety");
Bird eagle = new Eagle("Goldie");

sparrow.DisplayInfo();
sparrow.Eat();
sparrow.Fly();

Console.WriteLine();

eagle.DisplayInfo();
eagle.Eat();
eagle.Fly();

// ISP - Interface Segregation Principle Demo
Console.WriteLine("\n========== ISP Demo (Interface Segregation Principle) ==========");
var multiFunctionPrinter = new MultiFunctionPrinter();
multiFunctionPrinter.Print("Report.pdf");
multiFunctionPrinter.Scan("Document.pdf");

// DIP - Dependency Inversion Principle Demo
Console.WriteLine("\n========== DIP Demo (Dependency Inversion Principle) ==========");
IKeyboard keyboard = new MechanicalKeyboard();
var computer = new Computer(keyboard);
computer.Input("Hello SOLID Principles!");
