void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i == array.Length-1)
        {
            break;
        }
        else
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

int Quadrato(int numero)
{
    return numero *= numero;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] newArray = new int[array.Length];
    array.CopyTo( newArray, 0 );

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = Quadrato(newArray[i]);
    }
    return newArray;
}

int sommaElementiArray(int[] array)
{
    int somma = 0;
    foreach (int n in array)
    {
        somma += n;
    }
    return somma;
}

Console.WriteLine("Inserisci il numero di elementi");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrayNumeri = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Inserisci il {i+1}° numero: ");
    arrayNumeri[i] = Convert.ToInt32(Console.ReadLine());
}

StampaArray(arrayNumeri);
StampaArray(ElevaArrayAlQuadrato(arrayNumeri));
Console.WriteLine("Array originale: ");
StampaArray(arrayNumeri);
Console.WriteLine($"Somma numeri: {sommaElementiArray(arrayNumeri)}");
Console.WriteLine($"Somma numeri elevati al quadrato: {sommaElementiArray(ElevaArrayAlQuadrato(arrayNumeri))}");
