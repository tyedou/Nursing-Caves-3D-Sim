using Immersive.Input;
using Immersive.Interactive;
using UnityEngine;

public class InteractiveButtonClick : InteractiveObjectBase
{
    [Header("Assign in Inspector")]
    public GameObject buttonVisual;     // optional
    public GameObject questionPanel;    // panel to toggle

    [Header("Optional")]
    public bool hideButtonWhenPanelOpens = false;

    private void Start()
    {
        if (questionPanel != null)
            questionPanel.SetActive(false);
    }

    public override void OnEnter()
    {
        // optional: highlight later
        // Debug.Log("On Enter");
    }

    public override void OnExit()
    {
        // optional: unhighlight later
        // Debug.Log("On Exit");
    }

    public override void Tap(TapInput tapInput)
    {
        TogglePanel();
    }

    private void TogglePanel()
    {
        if (questionPanel == null) return;

        bool newState = !questionPanel.activeSelf;
        questionPanel.SetActive(newState);

        if (hideButtonWhenPanelOpens && buttonVisual != null)
            buttonVisual.SetActive(!newState);
    }
}
