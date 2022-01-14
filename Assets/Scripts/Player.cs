using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float Speed;
    public int Armor;
    public int curr_health;
    public int Damage;
    public bool IsHitting=false;
    void Start()
    {
        curr_health = 100;

    }
    void Update()
    {
        
    }
    public void Takedamadge(int DMG)
    {
        if (curr_health <= 0)
        {
            gameObject.SetActive(false); ;
        }
        curr_health -= (DMG - Armor);
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
