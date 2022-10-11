using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle
{
    public class Wordle
    {
        //Miembros
        private string[] words;
        private string wordPlay;
        //private string userDecision;

        // Constructor Wordle estado inicial
        public Wordle(string wordPlay) 
        {
            words = new string[6];
           // this.UserDecision = "_____BBAR";
            for (int i = 0; i < words.Length; i++) words[i] = "_____";
            this.wordPlay = wordPlay.ToUpper();
        }
        // Getter setter 
        public string[] Words
        {
            get
            {
                return words;
            }
            set 
            {
                words = value;
            }
        }
        public string WordPlay
        {
            get
            {
                return this.wordPlay;
            }
            set
            { 
                this.wordPlay = value;
            }
        }
        //public string UserDecision
        //{
        //    get
        //    {
        //        return this.userDecision;
        //    }
        //    set 
        //    { 

        //        this.userDecision = value.ToUpper();
        //    }

        //}

    }
}
