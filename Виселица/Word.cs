using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Виселица
{
    public class Word
    {
        public string Category { get; set; }

        public string Value { get; private set; }
        public StringBuilder Mask { get; private set; }
        public StringBuilder WordLettersLeft { get; set; }

        public Word(string category)
        {
            string[] words;
            Category = category;
            words = File.ReadAllLines($"{category}.txt"); 
            Random rnd = new Random();
            int index_rnd = rnd.Next(words.Length - 1);
            
            Value = words[index_rnd];
            WordLettersLeft = new StringBuilder(Value);
            this.Mask = new StringBuilder(new string('*', this.Value.Length));
        }
        static public List<byte> IndexesOfLetter(string word, char playerLetter)
        {
            List<byte> listOfIndexes = new List<byte>();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == playerLetter)
                {
                    listOfIndexes.Add((byte)i);
                }
            }
            return listOfIndexes;
        }
        

        public bool ContainsLetter(char playerLetter)
        {
            List<byte> resultOfCheckLetter = IndexesOfLetter(this.WordLettersLeft.ToString(), playerLetter);
            return resultOfCheckLetter.Count > 0;
        }



        public void Update(char playerLetter)
        {
            this.cutWordLettersLeft(playerLetter);//есть буква(-ы) - удаляем из текущего слова
            this.RefreshMask(playerLetter);
        }

        public void cutWordLettersLeft(char playerLetter)
        {
            List<byte> resultOfCheckLetter = IndexesOfLetter(this.WordLettersLeft.ToString(), playerLetter);
            byte dec = 0;//для сдвига индекса влево, если было удаление
            foreach (byte i in resultOfCheckLetter)
            {
                this.WordLettersLeft.Remove(i - dec++, 1);
            }
        }
        public void RefreshMask(char playerLetter)
        {
            List<byte> resultOfCheckLetter = IndexesOfLetter(Value, playerLetter);
            foreach (byte i in resultOfCheckLetter)
            {
                this.Mask[i] = playerLetter;
            }
        }
        
    }
}
