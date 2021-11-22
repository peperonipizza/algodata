namespace AD
{
    public partial class Edge
    {
        public Vertex dest;
        public double cost;

        public Edge(Vertex d, double c)
        {
            dest = d;
            cost = c;
        }

        public int compareTo(Edge e)
        {
            double othercost = e.cost;
            return cost < othercost ? -1 : cost > othercost ? 1 : 0;
        }
    }
}