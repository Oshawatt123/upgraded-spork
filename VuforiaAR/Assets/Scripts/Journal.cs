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
        JournalEntry JournalEntryGun = new JournalEntry("This gun looks like it has been fired recently. You can smell the faint aura of Mountain Dew around the weapon.");
        JournalEntry JournalEntryBody = new JournalEntry("Wow, a body! Looks like it has been well preserved.");
        JournalEntry JournalEntryLitter = new JournalEntry("Some garbage.... looks like this is quite recent.");
        JournalEntry JournalEntryDoor = new JournalEntry("The door seems to be uncontrollably opening. Seems like someone with dexerity will be able to easily slip past.");
        JournalEntry JournalEntryBookshelf = new JournalEntry("The bookshelf is dirty and houses many magazines, books, and... other items.");
        JournalEntry JournalEntryScientist = new JournalEntry("The scientist said he saw some pink hair on the floor near the door earlier on, but he has no clue if he was correct.");
        JournalEntry JournalEntryScientist2 = new JournalEntry("'The smell of monster disturbs me...");

        entryList.Add(JournalEntryBody);
        entryList.Add(JournalEntryGun);
        entryList.Add(JournalEntryLitter);
        entryList.Add(JournalEntryDoor);
        entryList.Add(JournalEntryBookshelf);
        entryList.Add(JournalEntryScientist);
        entryList.Add(JournalEntryScientist2);
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
            case "Litter":
                textList[2].text = entryList[2].EntryDescription;
                break;
            case "Door":
                textList[3].text = entryList[3].EntryDescription;
                break;
            case "Bookshelf":
                textList[4].text = entryList[4].EntryDescription;
                break;
            case "Scientist":
                textList[5].text = entryList[5].EntryDescription;
                break;
            case "Scientist2":
                textList[6].text = entryList[6].EntryDescription;
                break;
        }
    }

}
