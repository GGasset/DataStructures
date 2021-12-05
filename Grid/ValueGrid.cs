using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class ValueGrid
    {
        /// <summary>
        /// Equivalent to y
        /// </summary>
        public List<Column> Columns;

        public ValueGrid()
        {
            Columns = new List<Column>();
        }

        public ValueGrid(List<Column> rows)
        {
            this.Columns = rows;
        }

        public ValueGrid(int width, int height, double type = 0)
        {
            Columns = new List<Column>();
            for (int x = 0; x < width; x++)
                Columns.Add(new Column(height, type));
        }

        public void SetCell(int x, int y, double value)
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

            public Column(int height = 0, double cellType = 0)
            {
                Cells = new List<Cell>();
                for (int x = 0; x < height; x++)
                    Cells.Add(new Cell(cellType));
            }

            public Cell this[int y] => Cells[y];
        }

        public class Cell
        {
            public double value;

            public Cell(double type)
            {
                value = type;
            }
        }
    }

}
