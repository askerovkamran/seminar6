// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов 
// (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, 
// но отсортированный по возрастанию(от меньшего числа к большему).

int[] array = GetArray(6 , 0, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine(" = {CountElement(array)}");

Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

// -----------------Метод---------------------

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}



int res;
for (int i = 0; i < array.Length -1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            res = array[i];
            array[i] = array[j];
            array[j] = res;
        }
    }
}