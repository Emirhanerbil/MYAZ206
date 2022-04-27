using DataStructures.LinkedList.SinglyLinkedList;

Console.WriteLine(Factoriel(6));
Console.WriteLine(Summary(10));
Console.WriteLine(Fibonacci(6));



int TraverseLinkedList(int number)
{
    var list = new SinglyLinkedList<int>(new int[] { 1, 3, 32, 4, 65, 4, 76, 4, 7, 8, 98, 9, 5, 33, 66, 88, 99, 0, 66 });
    var index = SearchIndex(number);
    return 0;

     int SearchIndex(int x)
    {
        if (x > list.Count)
        {
            var msg = Convert.ToInt32("Not found");
            return msg;
        }
        
        return 0;
        
    }
}


static int Factoriel(int n)

{
    int result1 = RecFactoriel(n);
    return result1;

    static int RecFactoriel(int x)
    {
        if (x == 1)
        {
            return 1;
        }
        var result = x * RecFactoriel(x-1);
        return result;

    }
}

static int Summary(int n)
{
    var result = 0;
    result = Result(n);
    return result;

    static int Result(int x)
    {
        if (x == 0)
        {
            return 0;
        }
        var result = x + Result(x-1);
        return result;
    }
}


static int Fibonacci(int index)
{
    
    return GetFibonacci(index);

    static int GetFibonacci(int x)
    {
        if ((x == 0) || (x == 1))
        {
            return x;
        }
        else
        {
            return (GetFibonacci(x - 1) + GetFibonacci(x - 2));
        }

    }
}

