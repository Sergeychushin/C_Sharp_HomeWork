 //Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.


Console.Write("Высота елки ");
int H = Int32.Parse(Console.ReadLine());
string Z = "*";
for (int i = 0; i < H; i++)
{
    Console.WriteLine(Z);
    Z += "**";

}
Console.ReadLine();

