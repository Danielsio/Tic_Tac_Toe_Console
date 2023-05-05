﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeConsole.Utillity;

namespace TicTacToeConsole.Model
{
    public class Player
    {
        private int m_Score;
        private BoardMark m_Symbol;
        private bool m_IsMachine;

        public Player(BoardMark i_Symbol, bool i_IsMachine) 
        {
            this.m_Score = 0;
            this.m_Symbol = i_Symbol;
            this.m_IsMachine = i_IsMachine;
        }

        public BoardMark Symbol
        {
            get 
            { 
                 return m_Symbol; 
            }
        }

        public int Score
        {
            get 
            { 
                 return m_Score; 
            }
        }
    }
}
