using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Interactive : MonoBehaviour, IDropHandler
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI health;
    [SerializeField] TextMeshProUGUI attack;
    [SerializeField] TextMeshProUGUI cost;
    public void OnDrop(PointerEventData eventData)
    {
        TextMeshProUGUI damage = eventData.pointerDrag.gameObject.GetComponent<Interactive>().attack;
        
        health.text = (int.Parse(health.text) - int.Parse(damage.text)).ToString();
    }


    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
