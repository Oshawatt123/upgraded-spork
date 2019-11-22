using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    class JournalEntry
    {
        string EntryDescription;
        bool discovered;

        public JournalEntry(string description)
        {
            EntryDescription = description;
        }

        public void discover()
        {
            discovered = true;
        }

    }

    List<JournalEntry> entryList = new List<JournalEntry>();

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
                entryList[0].discover();
                break;
            case "Gun":
                entryList[1].discover();
                break;
        }
    }

}
