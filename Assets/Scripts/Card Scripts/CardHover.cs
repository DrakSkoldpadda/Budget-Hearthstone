using UnityEngine;

public class CardHover : MonoBehaviour
{
    public float hoverHeight = 1f;
    public float timeToHover = 0.01f;
    public float timeToHoverBack = 0.5f;

    private Vector3 startPos;

    void OnMouseEnter()
    {
        startPos = transform.position;
        iTween.MoveTo(gameObject, new Vector3(transform.position.x, transform.position.y, transform.position.z - hoverHeight), timeToHover);
    }

    void OnMouseExit()
    {
        iTween.MoveTo(gameObject, new Vector3(startPos.x, startPos.y, -1), timeToHoverBack);
    }
}
