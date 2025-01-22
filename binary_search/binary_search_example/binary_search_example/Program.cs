
static int MySearchBinary(int[] numbers, int target)
{
    // a logica esta em manipular os indices de low e high caso o targe não corresponda a aposta(bet)

    var low = 0;
    var high = numbers.Length - 1;

    while (low <= high)
    {
        var middle = (int)Math.Floor((double)(low + high)/2);
        var bet = numbers[middle];

        if (bet == target)
            return middle;
        if (bet > target)
            high = middle - 1;
        if (bet < target)
            low = middle + 1;
    }

    return -1;
}

Console.WriteLine(MySearchBinary([1, 3, 5, 7, 9],3));



static int SearchBinary(int[] list, int target )
{
    var low = 0;
    var high = list.Length - 1; // 4
    while (low <= high)
    {
        var middle = (int)Math.Floor((double)(low + high) / 2); // 2
        var bet = list[middle]; // 5

        if (bet == target) // 5 == 3 ?
            return middle;
        if (bet > target) // 5 > 3 ? 
            high = middle - 1; // era 4  agora é 3
        if(bet < target)
            low = middle + 1;
    }
   
    return -1;
}

Console.WriteLine(SearchBinary([1,3,5,7,9],9));

























