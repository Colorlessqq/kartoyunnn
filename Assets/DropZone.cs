using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField]
    GameObject tile;
    public GameObject firstParent;
    bool IsFilled = false;
    public void OnDrop(PointerEventData eventData)
    {
        print(eventData.pointerDrag.name + "OnDrag Zone: " + gameObject.name);
        //if (!IsFilled)
        //{
        //    GameObject newHero = Instantiate(hero[0]);
        //    newHero.transform.position = tile.transform.position;
        //    newHero.transform.parent.SetParent(firstParent.transform);
        //    Destroy(eventData.pointerDrag.gameObject);
        //    IsFilled = true;

        //}
        //else { print("Dolu ataman"); }
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        d.original_parent = this.transform;
        

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //print("OnPointerEnter");
         
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //print(" OnPointerExit");
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
