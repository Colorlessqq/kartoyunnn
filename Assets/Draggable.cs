using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour,IBeginDragHandler, IEndDragHandler,IDragHandler
{
    // Start is called before the first frame update
    public Transform original_parent = null;
    //TODO:
    public void OnBeginDrag(PointerEventData eventData)
    {
        print("OnBeginDrag");
        original_parent = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;


    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        print("OnEndDrag");
        this.transform.SetParent(original_parent);
 
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
