using System;
using System.Collections.Generic;
using System.Drawing;

namespace DataStructures
{
    public class TypeGrid<T>
    {
        /// <summary>
        /// Equivalent to y
        /// </summary>
        public List<Column> Columns;

        public TypeGrid()
        {
            Columns = new List<Column>();
        }

        public TypeGrid(List<Column> rows)
        {
            this.Columns = rows;
        }

        public TypeGrid(int width, int height, T defaultType)
        {
            Columns = new List<Column>();
            for (int x = 0; x < width; x++)
                Columns.Add(new Column(defaultType, height));
        }

        public void SetCell(Point pos, T value)
        {
            SetCell(pos.X, pos.Y, value);
        }

        public void SetCell(int x, int y, T value)
        {
            if (x > Columns.Count || y > Columns[x].Cells.Count)
                throw new IndexOutOfRangeException();

            Columns[x].Cells[y].value = value;
        }

        public Column this[int x] => Columns[x];
        public Cell this[int x, int y] => Columns[x][y];

        public class Column
        {
            public List<Cell> Cells;

            public Column(T cellType, int height = 0)
            {
                Cells = new List<Cell>();
                for (int x = 0; x < height; x++)
                    Cells.Add(new Cell(cellType));
            }

            public Cell this[int y] => Cells[y];
        }

        public class Cell
        {
            public T value;

            public Cell(T type)
            {
                value = type;
            }
        }
    }
}
