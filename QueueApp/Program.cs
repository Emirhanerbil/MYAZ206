using Queue;
using QueueApp;

var queue = new Queue.Queue<ToDo>();

queue.EnQueue(new ToDo()
{
    Describe= "Kahvaltı Yap",
    Time = 12.00
}) ;
queue.EnQueue(new ToDo()
{
    Describe= "Okula git",
    Time = 13.00
});
queue.EnQueue(new ToDo()
{
    Describe= "Derse Gir",
    Time = 15.00
});

queue.DeQueue();

foreach (var item in queue)
{
    Console.WriteLine(item);
}

Console.ReadKey();