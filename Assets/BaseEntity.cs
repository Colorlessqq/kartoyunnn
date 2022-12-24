using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class BaseEntity : MonoBehaviour
{
    [SerializeField]
    bool IsEnemy;
    [SerializeField]
    public GameObject[] allEntitiyies;
    public GameObject firstParent;
    private void OnMouseDown()
    {
        // oyuncu karaterin üzerine bastığı zaman çalışır
        // ToDo: yapılabilcek hamleleri gösterir

    }
    // Start is called before the first frame update
    private void Awake()
    {
        allEntitiyies = firstParent.GetComponentsInChildren<GameObject>();

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
