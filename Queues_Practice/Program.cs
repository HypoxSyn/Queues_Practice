
//Queues can hold anything even objects
//Adding things to the queue- Enqueue
// FIFO first in first out

Queue<string> queue = new();


queue.Enqueue("Tim");

Console.WriteLine(queue.Peek());

queue.Enqueue("Wally");

Console.WriteLine(queue.Peek());

queue.Enqueue("Sierra");

Console.WriteLine(queue.Peek());

while(queue.Count > 0)
{
    Console.WriteLine("The person at the front of the line, {0}, was removed from the queue", queue.Dequeue());
    Console.WriteLine("Current total people in line: {0}", queue.Count);

}

static Order[] ReceiveOrdersFromBranch1()
    {
        Order[] orders = new Order[] 
        {
        new Order(1, 5),
        new Order(2, 6),
        new Order(7, 8)
        };
        return orders;
    }


class Order
{
    public int OrderId { get; set; }
    public int OrderQuantity { get; set; }

    public Order(int orderid, int orderquantity)
    {
        this.OrderId = orderid;
        this.OrderQuantity = orderquantity;
    }

    public void ProcessOrder()
    {
        Console.WriteLine($"Order {this.OrderId}");
    }
}




