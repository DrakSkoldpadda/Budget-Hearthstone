using UnityEngine;

public class Draggable : MonoBehaviour
{
    private bool isDragging;
    private DraggableActions da;
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
            transform.position = new Vector3(mousePos.x - cursorOffset.x, mousePos.y - cursorOffset.y, transform.position.z);
        }
    }

    void OnMouseDown()
    {
        if (da.CanDrag == true)
        {
            isDragging = true;
            zOffset = -Camera.main.transform.position.z + transform.position.z;
            da.OnStartDrag();

            cursorOffset = -transform.position + MouseInWorldCordinates();
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
