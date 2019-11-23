using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Journal : MonoBehaviour
{
    class JournalEntry
    {
        public string EntryDescription;
        bool discovered;

        public JournalEntry(string description)
        {
            EntryDescription = description;
        }
    }

    List<JournalEntry> entryList = new List<JournalEntry>();
    public List<TextMeshProUGUI> textList = new List<TextMeshProUGUI>();

    private void Start()
    {
        JournalEntry JournalEntryBody = new JournalEntry("Wow, a body! The body looks like it has been well preserved");
        JournalEntry JournalEntryGun = new JournalEntry("Wow, a gun! The gun looks like it has been fired recently :0");
        entryList.Add(JournalEntryBody);
        entryList.Add(JournalEntryGun);
    }

    public void ShowEntry(string name)
    {
        switch(name)
        {
            case "Body":
                textList[0].text = entryList[0].EntryDescription;
                break;
            case "Gun":
                textList[1].text = entryList[1].EntryDescription;
                break;
        }
    }

}
