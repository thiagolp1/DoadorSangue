int idade;

Console.Write("Qual a sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18 && idade <= 67)
{
    Console.WriteLine("voçê pode doar sangue.");
}

else
{
    Console.WriteLine("voçê não pode doar sangue.");
}