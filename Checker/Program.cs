int n = 21;
int[] array = new int[] { 3, 1, 8, 5, 4 };

Console.WriteLine(Checker(n, array));

bool Checker(int n, int[] array)
{    
    array = array
        .Where(x => x < n)
        .OrderByDescending(x => x).ToArray();

    int sum = 0;
    for (int index = 0; index < array.Length; index++)
    {
        sum += array[index];
        for (int i = index + 1; i < array.Length; i++)
        {            
            if (i == index || sum + array[i] > n)
                continue;            
            if (sum + array[i] == n)
                return true;
            sum += array[i];            
        }
        sum = 0;
    }
    
    return false;
}
