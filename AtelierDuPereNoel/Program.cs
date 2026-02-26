using AtelierDuPereNoel;
using AtelierDuPereNoel.Decorator;
using AtelierDuPereNoel.Factory;
using AtelierDuPereNoel.Observer;

Console.WriteLine("TP - Atelier du Père Noel");



var atelier = new Atelier();

var lutin1 = new Lutin("Farfelu");
var lutin2 = new Lutin("Clochette");

atelier.OnProductionEvent += lutin1.RecevoirNotification;
atelier.OnProductionEvent += lutin2.RecevoirNotification;

atelier.ProductToy("Poupée");


var bigFactory = new BigFactory();
bigFactory.AjouterFactory("Poupée", new DollFactory());
bigFactory.AjouterFactory("Robot", new RobotFactory());
bigFactory.AjouterFactory("Voiture", new CarFactory());


var toys = new List<IToy>();

var toy1 = bigFactory.ProductToy("Poupée");
toys.Add(toy1);

var toy2 = bigFactory.ProductToy("Robot");
toys.Add(toy2);

var toy3 = bigFactory.ProductToy("Voiture");
toys.Add(toy3);


Console.WriteLine("\nJouets avant décoration !");
foreach(var t in toys)
Console.WriteLine(t.Name);


Console.WriteLine("\nJouets après décoration !");
IToy t1Deco = new GiftWrapDecorator(toy1);
IToy t2Deco = new GiftWrapDecorator(new StickerDecorator(toy2));
IToy t3Deco = new GiftWrapDecorator(new StickerDecorator(toy3));


Console.WriteLine(t1Deco.Name);
Console.WriteLine(t2Deco.Name);
Console.WriteLine(t3Deco.Name);






