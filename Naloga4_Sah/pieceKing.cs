using System;
using System.Collections.Generic;
using System.Text;

namespace Naloga4_Sah
{
    public class King : ChessPiece
    {
        private const double chessWeight = double.PositiveInfinity;

        public King(ChessBoardField start) : base(start)
        {
            this.ChessWeight = chessWeight;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMoje ime je {this.GetType()}";
        }

        //TODO dodajte metodo premik, ki prepiše osnovon
        public override void Move(ChessBoardField field)
        {
            // Pravilo za preverbo premika Kralja
            //TODO MoveKing
            //koda
        }

    }
}
