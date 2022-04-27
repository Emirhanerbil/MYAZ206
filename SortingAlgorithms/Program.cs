var list = new int[] { 1, 3, 4, 2, 5, 7, 89, 5, 4, 7, 89, 5, 345, 345, 234, 5, 6, 4, 7, 8, 4, 7, 98 };

BubbleSort(list);



int[] SelectionSort(int[] list)
{
    
    int temp;
    int min;
    for (int i = 0; i <= list.Length-1; i++)
    {
        min = i;
        for (int j = i; j < list.Length; j++)
        {
            if (list[j]<list[min])
            {
                min = j;
            }
        }
        temp = list[i];
        list[i] = list[min];
        list[min] = temp;
    }
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
    return list;

}
int[] InsertSort(int[] list)
{
    int flag,val;
    for (int i = 1; i < list.Length; i++)
    {
        val = list[i];
        flag = 0;
        for (int j = i - 1; j >= 0 && flag != 1;)
        {
            if (val < list[j])
            {
                list[j + 1] = list[j];
                j--;
                list[j + 1] = val;
            }
            else flag = 1;
        }
    }
    Console.Write("\nSorted Array is: ");
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write(list[i] + " ");
    }
    return list;
}
int[] BubbleSort(int[] list)
{
    int temp;
    for (int i = 0; i < list.Length; i++)
    {
        
        for (int j = i+1; j < list.Length; j++)
        {
            if (list[j-1]>list[j])
            {
                temp = list[j-1];
                list[j-1] = list[j];
                list[j] = temp;

            }
        }
    }
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
    return list;
}

