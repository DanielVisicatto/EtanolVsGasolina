Console.Write("Digite o preço da Gasolina: ");
float precoGasolina = float.Parse(Console.ReadLine());

Console.Write("Digite o preço do Etanol: ");
float precoEtanol = float.Parse(Console.ReadLine());

float diferenca = precoEtanol / precoGasolina;
if (diferenca <= .72)
{
    Console.WriteLine("Use Etanol");
}
else
{
    Console.WriteLine("Use Gasolina");
}