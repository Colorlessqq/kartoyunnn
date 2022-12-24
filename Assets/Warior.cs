using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warior : BaseEntity
{
    // Can - kalkan - hasar - özel yetenek - bonuslar 
    // Start is called before the first frame update

    //Düz savaşçı artısı eksisi yok

    [SerializeField] int healt = 5;
    [SerializeField] int damage = 3;


    private void OnMouseDown()
    {
        print("yey you clik to me");
        // show possibilities
    }
}
