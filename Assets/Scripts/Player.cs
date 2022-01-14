using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float Speed;
    public int Armor;
    public int Health;
    public int Damage;
    public bool IsHitting=false;
    void Start()
    {

    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "HArmor":
                Armor = 20;
                break;
            case "MArmor":
                Armor = 15;
                break;
            case "LArmor":
                Armor = 10;
                break;
            case "Sword":
                Damage = 30;
                
                break;
            case "Bow":
                Damage = 15;
                
                break;
            case "Daggers":
                Damage=25;
                
                break;

        }
    }
}
