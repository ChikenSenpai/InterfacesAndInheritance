using interfaceTest;

Sedan s1 = new Sedan(60);
VW v1 = new VW(60);


Console.WriteLine($"Sedan: {s1.speed}\nVW: {v1.speed}");

s1.SpeedUp();
v1.SpeedUp();

Console.WriteLine("Sedan: {0}\nVW: {1}", s1.speed, v1.speed); //different way to write varibales in strings (only for WriteLine)