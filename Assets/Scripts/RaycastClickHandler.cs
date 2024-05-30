using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class RaycastClickHandler : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                IPointerClickHandler clickHandler = hit.collider.GetComponent<IPointerClickHandler>();
                if (clickHandler != null)
                {
                    // Create a PointerEventData object and pass it to the OnPointerClick method
                    PointerEventData eventData = new PointerEventData(EventSystem.current)
                    {
                        position = Input.mousePosition,
                        button = PointerEventData.InputButton.Left
                    };
                    clickHandler.OnPointerClick(eventData);
                }
            }
        }
    }
}
