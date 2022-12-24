using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deste : MonoBehaviour
{
    [SerializeField]
    public GameObject[] myDeck;
    [SerializeField]
    private GameObject myHand;

    public void ReturnCardToHand()
    {
        GameObject newCard = Instantiate(myDeck[0]);
        newCard.transform.SetParent(myHand.transform);

    }
    //public void ReturnCardToEnemeyHand()
    //{
    //    GameObject newCard = Instantiate(myDeck[0]);
    //    newCard.transform.SetParent(enemyHand.transform);

    //}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
