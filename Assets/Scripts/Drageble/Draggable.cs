using UnityEngine;

public class Draggable : MonoBehaviour
{
    public bool useCursorOffset = true;

    private DraggableActions da;
    private bool isDragging;
    private Vector3 cursorOffset = Vector3.zero;
    private float zOffset;

    void Awake()
    {
        da = GetComponent<DraggableActions>();
    }

    void Update()
    {
        if (isDragging == true)
        {
            Vector3 mousePos = MouseInWorldCordinates();
            da.OnDraggingInUpdate();
            transform.position = new Vector3(mousePos.x - cursorOffset.x, mousePos.y - cursorOffset.y, transform.position.z);
        }
    }

    void OnMouseDown()
    {
        if (da.CanDrag == true)
        {
            isDragging = true;
            da.OnDraggingInUpdate();
            zOffset = -Camera.main.transform.position.z + transform.position.z;

            if (useCursorOffset == true)
            {
                cursorOffset = -transform.position + MouseInWorldCordinates();
            }
            else
            {
                cursorOffset = Vector3.zero;
            }
        }
    }

    void OnMouseUp()
    {
        if (isDragging == true)
        {
            isDragging = false;
            da.OnEndDrag();
        }
    }

    private Vector3 MouseInWorldCordinates()
    {
        Vector3 screenMousePos = Input.mousePosition;
        screenMousePos.z = zOffset;
        return Camera.main.ScreenToWorldPoint(screenMousePos);
    }
}
