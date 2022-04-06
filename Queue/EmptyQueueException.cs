namespace Queue
{
    [Serializable]
    public class EmptyQueueException : Exception
    {
       private string message;
        public EmptyQueueException(string msg = "Queue is empty.") : base(msg)
        {
            
        }
    }
}
