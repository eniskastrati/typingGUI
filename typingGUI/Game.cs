using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace typingGUI
{
    internal class Game
    {
        bool _alive = false;
        private int _wordCount;
        private int _correctWordsTyped;
        private int _wrongWordsTyped;
        public Game() 
        {
            this._alive= true;
            this._correctWordsTyped= 0;
            this._wrongWordsTyped= 0;
            this._wordCount = 0;
        }

        public void StartGame() 
        {
            
        }
    }
}
