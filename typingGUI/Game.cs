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
        private string _exerciseWords;
        List<string> diff;


        string[] words = {"which","the","of","and","a","to","in","that","it","with","as","for","was","on","are","be","by","this","at","but","from","or","not","an","what","one","have","were","will","all","my","we","can","there","use","your","they","if","be","no","Weltanschauung","Plethora","Dissertation","Loquacious","Obfuscate","Pensive","Disparate","Serendipity","Perfidious","Antipathy","Conundrum","Ineffable","Obsequious","Propinquity","Equanimity","Egregious","Salubrious","Magnanimous","Ennui","Exigent","Ephemeral","Irascible","Supercilious","Perfunctory","Inscrutable","Fastidious","Benign","Serene","Prophetic","Ephemeral","Luminous","Ameliorate","Inscrutable","Pernicious","Insidious","Ephemeral","Ameliorate","Perspicacious","Enigma","Esoteric","the","of","and","to","a","in","that","it","with","as","for","was","on","are","be","by","this","at","but","from","or","not","which","an","what","one","have","were","will","all","my","we","can","there","use","your","they","if","be","no","so","has","more","do","only","very","like","into","time","could","other","than","then","first","any","also","would","these","work","because"};

        public Game() 
        {
            this._alive= true;
            this._correctWordsTyped= 0;
            this._wrongWordsTyped= 0;
            this._wordCount = 0;
        }

        public void StartGame(int wordsAmmount) 
        {
            while(_alive){
                Random ram = new Random();
                for(int i = 0; i < wordsAmmount; i++){
                    _exerciseWords += " " + words[ram.Next(0, words.Length)];
                }
                return;
            }
        }

        public string GetExerciseWords(){
            return this._exerciseWords;
        }

        public void StopGame(string input)
        {
            _alive = false;
            IEnumerable<string> set1 = _exerciseWords.Split(' ').Distinct();
            IEnumerable<string> set2 = input.Split(' ').Distinct();

            if (set2.Count() > set1.Count())
            {
                diff = set2.Except(set1).ToList();
            }
            else
            {
                diff = set1.Except(set2).ToList();
            }
        }
        public string GetDiff() 
        {
            return string.Join(" ", diff);
        }
    }
}
