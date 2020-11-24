namespace Stairs
{
    public class Node
    {
        public Node(int idx)
        {
            Idx = idx;
        }

        public int Idx { get; }

        public Node Left { get; set; }
        
        public Node Right { get; set; }
    }
}
