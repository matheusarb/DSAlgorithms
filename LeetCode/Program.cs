// See https://aka.ms/new-console-template for more information
Console.WriteLine("LeetCode challenges:\n");

// 1. Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
int[] arr = { 2, 7, 9, 11, 15 };
var tg = 9;
int[] arr2 = { 2, 5, 5, 11 };

//DisplayArr(TwoSum(arr2, 10));
static int[] TwoSum(int[] nums, int target)
{
    var indexes = new int[2];
    var flag = false;

    for (var i = 0; i < nums.Length; i++)
    {
        if (flag)
            break;

        for (var j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                indexes[0] = i;
                indexes[1] = j;
                flag = true;
                break;
            }
        }
    }
    return indexes;
}
static void DisplayArr(int[] arr)
{
    foreach (var i in arr)
        Console.Write(i + " ");
}

// 2. Given an integer x, return true if x is a palindrome, and false otherwise
//Console.WriteLine(PalindromeNumber(567));
Console.WriteLine(PalindromeNumber2(242));
static bool PalindromeNumber(int num)
{
    string convertedNum = num.ToString();
    if (convertedNum.Length <= 1)
        return true;

    string reversed = "";

    for (var i = convertedNum.Length - 1; i >= 0; i--)
    {
        reversed += convertedNum[i];
    }

    if (reversed == convertedNum)
        return true;
    return false;
}

static bool PalindromeNumber2(int num)
{
    string convNum = num.ToString();
    if(convNum.Length <= 1)
        return true;

    var i = 0;
    var j = convNum.Length - 1;

    while(i < j)
    {
        if (convNum[i] != convNum[j])
            return false;
        i++;
        j--;
    }
    return true;
}