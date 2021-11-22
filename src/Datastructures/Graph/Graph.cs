using System;
using System.Collections.Generic;
using System.Linq;


namespace AD
{
    public partial class Graph : IGraph
    {
        public static readonly double INFINITY = System.Double.MaxValue;

        public Dictionary<string, Vertex> vertexMap;


        //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------

        public Graph()
        {
            vertexMap = new Dictionary<string, Vertex>();
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        /// <summary>
        ///    Adds a vertex to the graph. If a vertex with the given name
        ///    already exists, no action is performed.
        /// </summary>
        /// <param name="name">The name of the new vertex</param>
        public void AddVertex(string name)
        {
            if (!vertexMap.ContainsKey(name))
                vertexMap.Add(name, new Vertex(name));
        }


        /// <summary>
        ///    Gets a vertex from the graph by name. If no such vertex exists,
        ///    a new vertex will be created and returned.
        /// </summary>
        /// <param name="name">The name of the vertex</param>
        /// <returns>The vertex withe the given name</returns>
        public Vertex GetVertex(string name)
        {
            if (vertexMap.ContainsKey(name))
                return vertexMap.GetValueOrDefault(name);
            else
            {
                Vertex v = new Vertex(name);
                vertexMap.Add(name, v);
                return new Vertex(name);
            }
        }


        /// <summary>
        ///    Creates an edge between two vertices. Vertices that are non existing
        ///    will be created before adding the edge.
        ///    There is no check on multiple edges!
        /// </summary>
        /// <param name="source">The name of the source vertex</param>
        /// <param name="dest">The name of the destination vertex</param>
        /// <param name="cost">cost of the edge</param>
        public void AddEdge(string source, string dest, double cost = 1)
        {
            Vertex v1 = GetVertex(source);
            Vertex v2 = GetVertex(dest);
            v1.adj.AddLast(new Edge(v2, cost));
        }


        /// <summary>
        ///    Clears all info within the vertices. This method will not remove any
        ///    vertices or edges.
        /// </summary>
        public void ClearAll()
        {
            vertexMap.Clear();
        }

        /// <summary>
        ///    Performs the Breatch-First algorithm for unweighted graphs.
        /// </summary>
        /// <param name="name">The name of the starting vertex</param>
        public void Unweighted(string name)
        {
            ClearAll();
            Vertex start;
            if (vertexMap.ContainsKey(name))
                start = vertexMap.GetValueOrDefault(name);
            else
                start = new Vertex(name);
            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(start);
            start.distance = 0;

            while (!(queue.Count() == 0))
            {
                Vertex v = queue.Dequeue();
                foreach (Edge e in v.adj)
                {
                    Vertex w = e.dest;
                    if (w.distance == INFINITY)
                    {
                        w.distance = v.distance + 1;
                        w.prev = v;
                        queue.Enqueue(w);
                    }
                }
            }
        }

        /// <summary>
        ///    Performs the Dijkstra algorithm for weighted graphs.
        /// </summary>
        /// <param name="name">The name of the starting vertex</param>
        public void Dijkstra(string name)
        {
            PriorityQueue<Edge> prioqueue = new PriorityQueue<Edge>();
            Vertex start = vertexMap.GetValueOrDefault(name);
            if (start == null)
                throw new Exception();
            ClearAll();
            prioqueue.Add(new Edge(start, 0));
            start.distance = 0;
            int nodesSeen = 0;
            while(!(prioqueue.Size() > 0) && nodesSeen < vertexMap.Count())
            {
                Edge vrec = prioqueue.Remove();
                Vertex v = vrec.dest;
                if (v.known)
                    continue;
                v.known = true;
                nodesSeen++;
                foreach (Edge edge in v.adj)
                {
                    Vertex w = edge.dest;
                    double cvw = edge.cost;
                    if (w.distance > v.distance + cvw)
                    {
                        w.distance = v.distance + cvw;
                        w.prev = v;
                        prioqueue.Add(new Edge(w, w.distance));
                    }
                }
            }
        }

        //----------------------------------------------------------------------
        // ToString that has to be implemented for exam
        //----------------------------------------------------------------------

        /// <summary>
        ///    Converts this instance of Graph to its string representation.
        ///    It will call the ToString method of each Vertex. The output is
        ///    ascending on vertex name.
        /// </summary>
        /// <returns>The string representation of this Graph instance</returns>
        public override string ToString()
        {
            string s = "";
            foreach (string key in vertexMap.Keys.OrderBy(x => x))
            {
                s+= vertexMap.GetValueOrDefault(key).ToString();
            }
            return s;
        }


        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------



        public bool IsConnected()
        {
            return true;
            //throw new System.NotImplementedException();
        }

    }
}