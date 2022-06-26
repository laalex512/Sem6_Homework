/*Задача 41: Пользователь вводит с клавиатуры числа через запятую. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/

string InputStr(string mes)
{
    Console.Write($"Insert {mes}: ");
    return Console.ReadLine();
}

int countPositive = 0;
string userMessage = InputStr("message");
string currentNumber = string.Empty;

//для проверки первого числа:
for (int i = 0; userMessage[i] != ','; i++)
{
    currentNumber += userMessage[i];
}

if (Convert.ToInt32(currentNumber) > 0)
    countPositive++;

// для проверки остальных чисел:

for (int i = 0; i < userMessage.Length; i++)
{
    if (userMessage[i] == ',')
    {
        currentNumber = string.Empty;
        int j = i + 1;                                                // +1 - это пробел после запятой
        while (j < userMessage.Length && userMessage[j] != ',')
        {
            currentNumber += userMessage[j];
            j++;
        }
        if (Convert.ToInt32(currentNumber) > 0)
            countPositive++;
    }
}

Console.Write("count positive: " + countPositive);
