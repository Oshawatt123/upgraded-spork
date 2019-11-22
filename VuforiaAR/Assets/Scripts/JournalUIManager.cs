using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalUIManager : MonoBehaviour
{
    public CanvasGroup MainGroup;
    public CanvasGroup JournalGroup;
    public CanvasGroup JournalUpdateGroup;

    private void Start()
    {
        HideGroup(JournalGroup);
        HideGroup(JournalUpdateGroup);

        ShowGroup(MainGroup);
    }

    public void ShowJournal()
    {
        HideGroup(MainGroup);
        ShowGroup(JournalGroup);
    }

    public void ShowMainHUD()
    {
        HideGroup(JournalGroup);
        ShowGroup(MainGroup);
    }
    private void ShowGroup(CanvasGroup group)
    {
        group.alpha = 1f;
        group.interactable = true;
        group.blocksRaycasts = true;
    }
    private void HideGroup(CanvasGroup group)
    {
        group.alpha = 0f;
        group.interactable = false;
        group.blocksRaycasts = false;
    }
}