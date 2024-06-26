﻿// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

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
//Console.WriteLine(PalindromeNumber2(22));
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
    if (convNum.Length <= 1)
        return true;

    var i = 0;
    var j = convNum.Length - 1;

    while (i < j)
    {
        if (convNum[i] != convNum[j])
            return false;
        i++;
        j--;
    }
    return true;
}

// 3. Write a function to find the longest common prefix string amongst an array of strings.
// If there is no common prefix, return an empty string "".

// Example 1:
// Input:
// strs = ["flower", "flow", "flight"]
// Output:
// "fl"

List<string> test = new() { "flower", "flow", "flight" };
string[] test2 = { "flower", "flow", "flight" };

//Console.WriteLine(LCP(test2));
static string LongestCommomPrefix(List<string> strs)
{
    List<string> sortedStrs = strs;
    sortedStrs.Sort();

    var size = sortedStrs.Count;
    bool unmatch = false;
    var prefix = "";

    for (var i = 0; i < sortedStrs[0].Length; i++)
    {
        if (unmatch)
            break;

        if (sortedStrs[0][i] == sortedStrs[size - 1][i])
        {
            prefix += sortedStrs[0][i];
        }
        else
        {
            unmatch = true;
        }
    }

    return prefix;
}

static string LCP(string[] strs)
{
    var prefix = "";
    if (strs.Length == 1)
        return strs[0];

    //1. sort the array
    string[] sortedStrs = strs;
    Array.Sort(sortedStrs);
    var size = sortedStrs.Length;

    //2. check between first and last element
    for (var i = 0; i < sortedStrs[0].Length; i++)
    {
        if (sortedStrs[0][i] == sortedStrs[size - 1][i])
            prefix += sortedStrs[0][i];
        else
            break;
    }

    return prefix;
}

// 4. Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
// Example 2:

//Input:
//s = "()[]{}"
//Output:
//true
//Example 3:

//Input:
//s = "(]"
//Output: false

static bool isValid(string str)
{
    if (str.Length <= 1)
        return false;

    // 1. para cada char ([{ tem q ter o par fechando
    for (var i = 0; i < str.Length; i++)
    {
        if (str[i] == '(')
        {
            if (!str.Contains(")"))
                return false;
        }
        if (str[i] == '[')
        {
            if (!str.Contains("]"))
                return false;
        }
        if (str[i] == '{')
        {
            if (!str.Contains("}"))
                return false;
        }
    }

    return true;
}

// 5. Binary algorithm
// var binaryList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// int[] arrBi = { 1, 3, 5, 7, 9 };
// bynary(arrBi, 7);
//binarySearch(binaryList, 8);
static void binarySearch(List<int> list, int item)
{
    int baixo, alto, meio;

    baixo = 0;
    alto = list.Count - 1;
    meio = 0;

    while (baixo <= alto)
    {
        meio = (baixo + alto) / 2;
        var chute = list[meio];
        if (chute == item)
            Console.WriteLine(chute);
        if (chute > item)
            alto = meio - 1;
        else
            baixo = meio + 1;
    }
}

static void bynary(int[] arr, int num)
{
    int lowest, highest;
    lowest = 0;
    highest = arr.Length - 1;

    while (lowest <= highest)
    {
        var middle = (lowest + highest) / 2;
        var guess = arr[middle];
        if (guess == num)
            Console.WriteLine(middle);
        if (guess > num)
            highest = middle - 1;
        else
            lowest = middle + 1;
    }
}

//6. Romano para inteiros. Dado um algarismo romano, converta para inteiro
romanToInteger("MCMXCIV");
static void romanToInteger(string str)
{
    var romanDict = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    int integerResult = 0;
    int prevValue = 0;
    
    for(var i = str.Length - 1; i >= 0; i--)
    {
        int currValue = romanDict[str[i]];
        
        if(currValue < prevValue)
            integerResult -= currValue;
        else
            integerResult += currValue;
        prevValue = currValue;
    }
    System.Console.WriteLine(integerResult);
}