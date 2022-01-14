using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float startdelay =3f;
    public float enddelay=3f;
    public CameraControl cameracontrol;
    //public text messagetext;
    public GameObject playerprefab;
    public playermanager[] player;

    private WaitForSeconds startwait;
    private WaitForSeconds endwait;
    private playermanager gamewinner;



    void Start()
    {
       startwait=new WaitForSeconds(startdelay);
       endwait=new WaitForSeconds(enddelay);
       spawnallplayers();
       setcameratargets();
       cameracontrol.SetStartPositionAndSize();


    }

    private void spawnallplayers()
    {
        for(int i=0;i<player.Length;i++)
        {
            player[i].instance=Instantiate(playerprefab,player[i].spawnpoint.position,player[i].spawnpoint.rotation)as GameObject;
            player[i].playernumber=i+1;
            player[i].Setup();
        }
    }

    private void setcameratargets()
    {
        Transform[] targets=new Transform[player.Length];
        for (int i=0;i<targets.Length;i++)
        {
            targets[i]=player[i].instance.transform;
        }
        cameracontrol.m_Targets=targets;
    }

    

   /* private bool oneplayerleft()
    {
        int numplayersleft=0;
        for(int i=0;i<player.Length;i++)
        {
            if(player[i].instance.activeSelf)
           numplayersleft++;
        }
        return numplayersleft<=1;
    }

    private playermanager getgamewinner()
    {
        for(int i=0;i<player.Length;i++)
        {if(player[i].instance.activeSelf)
        return player[i];}
        return null;
    }

   */

    void Update()
    {
        
    }
}
