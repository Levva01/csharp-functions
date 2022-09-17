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