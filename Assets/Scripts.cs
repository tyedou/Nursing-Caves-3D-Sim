using UnityEngine;
using Immersive.Input;
using Immersive.Interactive;

public class DialogueHotspotTouch : InteractiveObjectBase
{
    public GameObject dialoguePanel;

    public override void Tap(TapInput tapInput)
    {
        if (dialoguePanel == null)
        {
            Debug.Log("Dialogue panel not assigned.");
            return;
        }

        dialoguePanel.SetActive(true);
        Debug.Log("Hotspot tapped – dialogue opened.");
    }
}
