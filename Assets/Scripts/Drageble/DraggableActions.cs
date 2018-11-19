using UnityEngine;

public abstract class DraggableActions : MonoBehaviour
{
    public abstract void OnStartDrag();

    public abstract void OnEndDrag();

    public virtual bool CanDrag
    {
        get
        {
            return true;
        }
    }

    protected abstract bool DragSuccessful();
}
