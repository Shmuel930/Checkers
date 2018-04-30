using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex02
{
    public class Cell
    {
        private const char EMPTY_CELL = ' ';
        private bool m_hasPiece;

        private char m_cellValue = EMPTY_CELL;

        public bool HasPiece
        {
            get { return m_hasPiece; }
            set { m_hasPiece = value; }
        }

        public char Value
        {
            get { return m_cellValue; }
            set { m_cellValue = value; }
        }
        public void DrawCell()
        {
            Console.Write(m_cellValue);
        }
    }
}
