using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        other.gameObject.GetComponent<Player>().Takedamadge(other.gameObject.GetComponent<Player>().Damage);
        
    }


}
