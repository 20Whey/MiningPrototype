using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonClickHandler : MonoBehaviour, IPointerClickHandler
{
    public GameObject spawnpoint1, spawnpoint2, spawnpoint3;
    public GameObject spawnpoint;
    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject clickedButton = eventData.pointerPress;
        if (clickedButton != null)
        {
            Canvas canvas = FindCanvasWithTag(clickedButton.transform);
            if (canvas != null)
            {
                Debug.Log("Clicked button is on canvas with tag: " + canvas.tag);
            }
            else
            {
                Debug.LogWarning("Canvas with tag 'path1' not found in the hierarchy.");
            }
        }
    }

    private Canvas FindCanvasWithTag(Transform obj)
    {
        while (obj != null)
        {
            Canvas canvas = obj.GetComponent<Canvas>();
            if (canvas != null && canvas.CompareTag("Path1"))
            {
                Instantiate(spawnpoint, spawnpoint1.transform.position, spawnpoint1.transform.rotation);

                return canvas;
            }
            else if (canvas != null && canvas.CompareTag("Path2"))
            {
                Instantiate(spawnpoint, spawnpoint2.transform.position, spawnpoint2.transform.rotation);

                return canvas;

            }
            else if (canvas != null && canvas.CompareTag("Path3"))
            {
                Instantiate(spawnpoint, spawnpoint3.transform.position, spawnpoint3.transform.rotation);

                return canvas;

            }
            obj = obj.parent;
        }
        return null;
    }
}
