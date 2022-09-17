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
        Quadrato(newArray[i]);
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
