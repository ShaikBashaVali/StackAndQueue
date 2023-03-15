namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Stack and Queue Linked List");
            StackLinkedList stackLinkedList = new StackLinkedList();
            QueueLinkedList queueLinkedList = new QueueLinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("A]Stack Linked List 1.Push 2.Peek 3.Pop 4.Empty 5.Size" +
                    "\nB]6.Enqueue   7.exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        stackLinkedList.Push(70);
                        stackLinkedList.Push(30);
                        stackLinkedList.Push(56);
                        stackLinkedList.Display();
                        break;
                    case 2:
                        stackLinkedList.peek();
                        stackLinkedList.Display();
                        break;
                    case 3:
                        stackLinkedList.Pop();
                        stackLinkedList.Display();
                        break;
                    case 4:
                        stackLinkedList.Empty();
                        break;
                    case 5:
                        int a = stackLinkedList.Size();
                        Console.WriteLine("Size is " + a);
                        break;
                    case 6:
                        queueLinkedList.Equeue(70);
                        queueLinkedList.Equeue(30);
                        queueLinkedList.Equeue(56);
                        queueLinkedList.Display();
                        break;
                    
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
        }
    }
}