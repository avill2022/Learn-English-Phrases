using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace Phrases
{
    class Phrase
    {
        private String phraseE;
        public String _phraseE { get { return phraseE; } }
        private String phraseI;
        public String _phraseI { get { return phraseI; } }
        private SoundPlayer Callphrase;
        private int indice;

        public Phrase(String E,String I,int i)
        {
            phraseI = I;
            phraseE = E;
            indice = i;
            Callphrase = new SoundPlayer();
            Callphrase.SoundLocation = "sound_\\" + i.ToString() + ".wav";
        }
        public void play()
        {
            Callphrase.Play();
        }
    }
}
