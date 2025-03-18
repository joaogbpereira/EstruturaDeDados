public class ListaOrdenada
{
    private Node head;

    public void InserirOrdenado(int data)
    {
        Node newNode = new Node(data);
        if (head == null || head.Data >= newNode.Data)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null && current.Next.Data < newNode.Data)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }
    }
}
