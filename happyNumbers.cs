public bool IsHappy(int n)
{
    if (n == 1)
    {
        return true;
    }

    string sumString = Convert.ToString(n);
    char[] sumArray = sumString.ToCharArray();
    int total = 0;

    while (total != 1)
    {
        for (var i = 0; i < sumArray.Length; i++)
        {
            var num = int.Parse(sumArray[i].ToString());
            total += (int)Math.Pow(num, 2);
        }

        if (total == 89) return false;

        sumArray = Convert.ToString(total).ToCharArray();

        if (total != 1)
        {
            total = 0;
        }
    }

    return true;
}