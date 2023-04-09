static void Permutations(string str, int left, int right)
{
    if (left == right)
        Console.WriteLine(str);
    else
    {
        for (int i = left; i <= right; i++)
        {
            str = Swap(str, left, i);
            Permutations(str, left + 1, right);
            str = Swap(str, left, i); 
        }
    }
}

static string Swap(string str, int i, int j)
{
    char temp;
    char[] charArray = str.ToCharArray();
    temp = charArray[i];
    charArray[i] = charArray[j];
    charArray[j] = temp;
    return new string(charArray);
}

string str = Console.ReadLine();
int n = str.Length;
Permutations(str,0,n-1);