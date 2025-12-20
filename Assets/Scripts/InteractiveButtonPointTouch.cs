using UnityEngine;

public class InteractiveButtonPointTouch : MonoBehaviour
{
    [Header("Assign in Inspector")]
    public Camera playerCamera;
    public GameObject buttonVisual;     // optional
    public GameObject questionPanel;

    [Header("Raycast")]
    public float maxDistance = 20f;
    public LayerMask hitLayers = ~0;

    [Header("Optional")]
    public bool hideButtonWhenPanelOpens = false;

    private Collider myCol;

    private void Awake()
    {
        myCol = GetComponent<Collider>();

        if (questionPanel != null)
            questionPanel.SetActive(false);
    }

    private void Update()
    {
        if (playerCamera == null || myCol == null) return;

        if (Input.GetMouseButtonDown(0))
            TryHit();

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            TryHit();
    }

    private void TryHit()
    {
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);

        if (!Physics.Raycast(ray, out RaycastHit hit, maxDistance, hitLayers, QueryTriggerInteraction.Ignore))
            return;

        if (hit.collider == myCol || hit.collider.transform.IsChildOf(transform))
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
