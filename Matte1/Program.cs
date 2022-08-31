// See https://aka.ms/new-console-template for more information

double num1, num2;
string username;//sträng som ska anges
Console.WriteLine("Skriva in ditt namn:");
username = Console.ReadLine();/* med metoden ReadLine() skrivs den första strängen som inte står som ett argument in*/
Console.WriteLine("Hej {0}!", username);/* {0} indikerar platsen där innehållet i användarnamnsvariabeln kommer att skrivas ut*/
Console.WriteLine("Ange nummer ett:");
num1 = Convert.ToDouble
(Console.ReadLine());/*konverterar sträng till dubbel typ */
Console.WriteLine("Ange nummer två");
num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Summan av {0} och {1} är {2}.", num1,
num2, num1 + num2);/*med {0} representeras {1} och {2} platser för tre variabler*/
Console.WriteLine("Differensen mellan {0} och {1} är {2}.",
num2, num1, num1 - num2);
Console.WriteLine("Produkten av {0} och {1} är {2}.", num1,
num2, num1 * num2);
Console.WriteLine("Kvoten av {0} och {1} är {2}.",
num1, num2, num1 / num2);
Console.WriteLine("Resten av {0} och {1} je {2}.",
num1, num2, num1 % num2);
Console.ReadKey();
