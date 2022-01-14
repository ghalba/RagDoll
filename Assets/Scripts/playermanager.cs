using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermanager : MonoBehaviour
{
    public Color playercolor;
    public Transform spawnpoint;
    [HideInInspector] public int playernumber;
    [HideInInspector] public string coloredplayertext;
    [HideInInspector]public GameObject instance;
    private PlayerMovment movement;
    private PlayerShooting shoot;
    private GameObject canvasgameobject;
    
    public void Setup()
    {
        movement=instance.GetComponent<PlayerMovment>();
        shoot=instance.GetComponent<PlayerShooting>();
        canvasgameobject=instance.GetComponentInChildren<Canvas>().gameObject;

        //movement.playernumber=playernumber;
        //shoot.playernumber=playernumber;

        coloredplayertext="<color=#"+ColorUtility.ToHtmlStringRGB(playercolor)+">player"+playernumber+"</color>";

        MeshRenderer[] renderers = instance.GetComponentsInChildren<MeshRenderer> ();

        for (int i = 0; i < renderers.Length; i++)
        {
            
            renderers[i].material.color = playercolor;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
