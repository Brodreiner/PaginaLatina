using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Word
{
    public string latein;
    public string deutsch;



    public Word(string latein, string deutsch)
    {
        this.latein = latein;
        this.deutsch = deutsch;
    }
}

public class WordManager : MonoBehaviour {

    private System.Random rnd = new System.Random();
    private List<Word> wordList;


    public List<Word> GetWords(uint count)
    {
        if (wordList.Count < count)
            throw new System.Exception("Word list does not contain enough elements!");
        List<Word> selectedWords = new List<Word>();
        while(selectedWords.Count < count)
        {
            Word word = wordList[rnd.Next(wordList.Count)];
            if (!selectedWords.Contains(word))
                selectedWords.Add(word);
        }

        return selectedWords;
    }

    public WordManager()
    {
        wordList = new List<Word>();
        FillWordList();
    }

    private void FillWordList()
    {
        wordList.Add(new Word("a, ab, abs", "von"));
        wordList.Add(new Word("ad", "an"));
        wordList.Add(new Word("ager", "Acker, Feld"));
        wordList.Add(new Word("aliquis", "jemand"));
        wordList.Add(new Word("altus, alta, altum", "hoch, tief"));
        wordList.Add(new Word("ante", "vor"));
        wordList.Add(new Word("autem", "aber"));
        wordList.Add(new Word("brevis", "kurz"));
        wordList.Add(new Word("capere", "erobern"));
        wordList.Add(new Word("caput, capis", "Kopf"));
        wordList.Add(new Word("corpus, corporis", "Körper"));
        wordList.Add(new Word("cui", "wem?"));
        wordList.Add(new Word("cum", "da, indem, dadurch dass"));
    }

}
