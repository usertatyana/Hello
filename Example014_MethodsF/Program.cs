//1. Найти позицию минимального элемента
//в неотсортированной части массива
//2. Произвести обмен этого значения со
//значением первой неотсортированной позиции
//3. Повторять пока есть не отсортированные
//элементы

int[] arr = { 1, 5, 4, 3, 6, 8, 9 };// массив который будем отсортировывать

//вывести данный массив на экран
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

// метод который упорядочит массив

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)   // ищет max элемент
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temmporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temmporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);