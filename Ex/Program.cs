string InputMessage(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

string[] rowsOfElements()
{
    int size = Convert.ToInt32(InputMessage("Какое количество элементов массива вы планируете ввести? "));
    string[] elements = new string[size];

    for (int i = 0; i < size; i++)
    {
        elements[i] = InputMessage($"{i + 1}-й элемент, нажмите Enter: ");
    }

    return elements;
}

int FindSizeOfNewArray(string[] array, int newLength)
{
    int sizeNewMassiv = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < newLength)
        {
            sizeNewMassiv++;
        }
    }
    return sizeNewMassiv;
}

string[] resultNewArrayOfStrings(string[] array, int size, int newLength)
{
    string[] newMassiv = new string[size];

    int i = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length < newLength)
        {
            newMassiv[i] = array[j];
            i++;
        }

    }
    return newMassiv;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"'{array[i]}', ");
        }
        if (i == array.Length - 1)
        {
            Console.Write($"'{array[i]}']");
        }
    }
}

Console.Clear();
string[] massiv = rowsOfElements();
PrintArray(massiv);
int maxLength = 4;
int sizeOfNewMassiv = FindSizeOfNewArray(massiv, maxLength);
if (sizeOfNewMassiv == 0)
{
    Console.Write(" -> ");
    Console.WriteLine("[]");
}
if (sizeOfNewMassiv != 0)
{
    string[] newMassiv = resultNewArrayOfStrings(massiv, sizeOfNewMassiv, maxLength);
    Console.Write(" -> ");
    PrintArray(newMassiv);
}