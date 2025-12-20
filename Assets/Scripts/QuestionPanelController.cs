using UnityEngine;
using System.Collections;

public class QuestionPanelController : MonoBehaviour
{
    [Header("Assign")]
    public GameObject questionPanel;      // parent
    public RectTransform menuBox;         // the sliding box

    [Header("Slide")]
    public float openX = 0f;
    public float closedX = 800f;          // start offscreen
    public float speed = 12f;

    bool isOpen;
    Coroutine anim;

    void Start()
    {
        if (questionPanel != null) questionPanel.SetActive(false);
        if (menuBox != null)
        {
            var p = menuBox.anchoredPosition;
            p.x = closedX;
            menuBox.anchoredPosition = p;
        }
    }

    public void TogglePanel()
    {
        if (questionPanel == null || menuBox == null) return;

        isOpen = !isOpen;
        questionPanel.SetActive(true);

        if (anim != null) StopCoroutine(anim);
        anim = StartCoroutine(SlideTo(isOpen ? openX : closedX));
    }

    IEnumerator SlideTo(float targetX)
    {
        while (true)
        {
            var p = menuBox.anchoredPosition;
            p.x = Mathf.Lerp(p.x, targetX, Time.deltaTime * speed);
            menuBox.anchoredPosition = p;

            if (Mathf.Abs(p.x - targetX) < 0.5f) break;
            yield return null;
        }

        var done = menuBox.anchoredPosition;
        done.x = targetX;
        menuBox.anchoredPosition = done;

        if (!isOpen) questionPanel.SetActive(false);
    }

    public void Close()
    {
        if (isOpen) TogglePanel();
    }
}
