// See https://aka.ms/new-console-template for more information

Console.WriteLine(AlphabetCounter("Hello"));

Console.WriteLine(AlphabetCounter("Hello World"));

int AlphabetCounter(string word)
{

    word = word.ToLower();

    if (!word.All(Char.IsLetter))
    {
        return -1;
    }

    char[] chars = new char[] { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

    int sum = 0;

    for (int w = 0; w < word.Length; w++)
    {
        for (int c = 0; c < chars.Length; c++)
        {
            if (word[w] == chars[c])
            {
                sum += c + 1;
            }
        }
    }

    return sum;
}