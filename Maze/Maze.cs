using System;
using System.Collections.Generic;
using System.Drawing;

namespace Jthomson.Maze
{
    class Maze
    {
        private MazeNode[,] nodes;
        private int rows, cols;
        private MazeNode start, end;

        public int CellSize { get; set; }

        public Maze(int cols, int rows)
        {
            this.rows = rows;
            this.cols = cols;
            this.nodes = new MazeNode[cols, rows];

            MazeNode mn;
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    mn = new MazeNode();
                    if (x == 0)
                    {
                        mn.SetIsEdge(Direction.West);
                    }
                    if (x == cols - 1)
                    {
                        mn.SetIsEdge(Direction.East);
                    }
                    if (y == 0)
                    {
                        mn.SetIsEdge(Direction.North);
                    }
                    if (y == rows - 1)
                    {
                        mn.SetIsEdge(Direction.South);
                    }
                    nodes[x, y] = mn;
                }
            }

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    mn = nodes[x, y];
                    if (!mn.GetIsEdge(Direction.North))
                    {
                        mn.SetNeighbour(Direction.North, nodes[x, y - 1]);
                    }
                    if (!mn.GetIsEdge(Direction.East))
                    {
                        mn.SetNeighbour(Direction.East, nodes[x + 1, y]);
                    }
                    if (!mn.GetIsEdge(Direction.South))
                    {
                        mn.SetNeighbour(Direction.South, nodes[x, y + 1]);
                    }
                    if (!mn.GetIsEdge(Direction.West))
                    {
                        mn.SetNeighbour(Direction.West, nodes[x - 1, y]);
                    }
                }
            }

            start = nodes[0, 0];
            end = nodes[cols - 1, rows - 1];

        }

        public void Generate(bool recursive = false)
        {

            if (recursive)  
            {
                // Recursive method
                nodes[cols / 2, rows / 2].Explore();
            }
            else
            {
                // Non recursive method
                Stack<MazeNode> nodeStack = new Stack<MazeNode>();
                nodeStack.Push(nodes[cols / 2, rows / 2]);

                while (nodeStack.Count > 0)
                {
                    MazeNode current = nodeStack.Pop();
                    current.Visited = true;
                    MazeNode rn = current.GetRandomUnvisitedNeighbour();
                    if (rn != null)
                    {
                        current.BreakWallTo(rn);
                        nodeStack.Push(current);
                        nodeStack.Push(rn);
                    }
                }
            }
        }

        public void Draw(Graphics g, Pen p)
        {
            MazeNode mn;
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    mn = nodes[x, y];
                    if (mn.WallExists(Direction.North))
                    {
                        g.DrawLine(p,
                            (x + 0) * CellSize, (y + 0) * CellSize,
                            (x + 1) * CellSize, (y + 0) * CellSize);
                    }
                    if (mn.WallExists(Direction.South))
                    {
                        g.DrawLine(p,
                            (x + 0) * CellSize, (y + 1) * CellSize,
                            (x + 1) * CellSize, (y + 1) * CellSize);
                    }
                    if (mn.WallExists(Direction.West))
                    {
                        g.DrawLine(p,
                            (x + 0) * CellSize, (y + 0) * CellSize,
                            (x + 0) * CellSize, (y + 1) * CellSize);
                    }
                    if (mn.WallExists(Direction.East))
                    {
                        g.DrawLine(p,
                            (x + 1) * CellSize, (y + 0) * CellSize,
                            (x + 1) * CellSize, (y + 1) * CellSize);
                    }
                    if (mn == end || mn == start)
                    {
                        g.DrawEllipse(new Pen(Color.Red, 1) , new Rectangle(x * CellSize + 2, y * CellSize + 2, CellSize - 4, CellSize - 4));
                    }
                }
            }
        }
    }
}
