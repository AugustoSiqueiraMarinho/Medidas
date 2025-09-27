// conversor de medidas
double m , cm, km;

Console.Write("Entre com a medida (em metros): ");
m = Convert.ToDouble(Console.ReadLine());

cm = m * 100;
km = m / 1000; 

Console.WriteLine("-- Equevalência ---");
Console.WriteLine($"{cm} cm");
Console.WriteLine($"{m} m");
Console.WriteLine($"{km} Km");

