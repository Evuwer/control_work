// задаем исходный массив строк
string[] inputArray = { "яблоко", "кот", "слон", "пес", "попугай" };

// создаем новый массив строк, содержащий только строки длины <= 3
string[] outputArray = new string[inputArray.Length];
int outputIndex = 0;
for (int i = 0; i < inputArray.Length; i++)
{
	if (inputArray[i].Length <= 3)
	{
		outputArray[outputIndex] = inputArray[i];
		outputIndex++;
	}
}

// выводим полученный массив на экран
Console.WriteLine("Массив строк длины <= 3:");
for (int i = 0; i < outputIndex; i++)
{
	Console.WriteLine(outputArray[i]);
}