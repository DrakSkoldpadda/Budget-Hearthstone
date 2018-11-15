using UnityEngine;

public class DraggableActionsReturn : DraggableActions
{
    public Vector3 savedPos;

    public override void OnDraggingInUpdate()
    {

    }

    public override void OnEndDrag()
    {
        iTween.MoveTo(this.gameObject, new Vector3(savedPos.x, savedPos.y, 0), 0.5f);
    }

    public override void OnStartDrag()
    {
        savedPos = transform.position;
    }

    protected override bool DragSuccessful()
    {
        return true;
    }
}
