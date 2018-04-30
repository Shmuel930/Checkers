using System;

namespace B18_Ex02
{
    public class HumanPlayer
    {
        private string m_name;
        private bool m_isWhite = true;
        
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }      
        
        public bool IsWhite
        {
            get { return m_isWhite; }
            set { m_isWhite = value; }
        }  
    }
}
