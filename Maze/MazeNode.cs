using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jthomson.Maze
{
    class MazeNode
    {
        public static Random rnd = new Random();

        bool visited;
        bool[] edges;
        bool[] walls;
        MazeNode[] neighbours;

        public MazeNode()
        {
            visited = false;
            edges = new bool[] { false, false, false, false }; // Probably not an edge
            walls = new bool[] { true, true, true, true }; // Starts will all 4 walls intact
            neighbours = new MazeNode[4];
        }

        public void SetIsEdge(Direction dir)
        {
            edges[(int)dir] = true;
        }

        public void SetNotEdge(Direction dir)
        {
            edges[(int)dir] = false;
        }

        public bool GetIsEdge(Direction dir)
        {
            return edges[(int)dir];
        }

        public bool WallExists(Direction dir)
        {
            return walls[(int)dir];
        }

        public void SetNeighbour(Direction dir, MazeNode mn)
        {
            neighbours[(int)dir] = mn;
        }

        public MazeNode GetNeighbour(Direction dir)
        {
            return neighbours[(int)dir];
        }

        public bool Visited
        {
            get { return visited; }
            set { visited = value; }
        }

        public void Explore()
        {
            this.Visited = true;
            while (true)
            {
                MazeNode rn = GetRandomUnvisitedNeighbour();
                if (rn == null)
                {
                    break;
                }
                this.BreakWallTo(rn);
                rn.Explore();
            }
        }

        public MazeNode GetRandomUnvisitedNeighbour()
        {
            var UnvisitedNeighbours = neighbours.Where<MazeNode>(mn => mn != null && !mn.visited).ToArray();
            MazeNode rndNeighbour = UnvisitedNeighbours.Length > 0 ? ShuffleArray<MazeNode>(UnvisitedNeighbours)[0] : null;

            return rndNeighbour;
        }

        public void BreakWallTo(MazeNode rndNeighbour)
        {
            Direction dir = (Direction)Array.FindIndex(neighbours, item => item == rndNeighbour);
            walls[(int)dir] = false;
            switch (dir)
            {
                case Direction.North:
                    rndNeighbour.walls[(int)Direction.South] = false;
                    break;
                case Direction.South:
                    rndNeighbour.walls[(int)Direction.North] = false;
                    break;
                case Direction.East:
                    rndNeighbour.walls[(int)Direction.West] = false;
                    break;
                case Direction.West:
                    rndNeighbour.walls[(int)Direction.East] = false;
                    break;
            }
        }

        // Note that this function WILL modify the original array AND return it
        public T[] ShuffleArray<T>(T[] array)
        {
            for (int i = array.Length; i > 1; i--)
            {
                int j = rnd.Next(i); 
                T tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
            return array;
        }

    }
}
