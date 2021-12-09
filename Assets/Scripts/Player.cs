using UnityEngine;

public class Player : MonoBehaviour
{
    
    private float Speed;
    private int Armor;
    private int Health;
    private int Damage;
    private float attackspeed;
    private bool IsHitting=false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "HArmor":
                Armor = 30;
                break;
            case "MArmor":
                Armor = 20;
                break;
            case "LArmor":
                Armor = 10;
                break;
            case "Sword":
                Damage = 20;
                attackspeed =3f;
                break;
            case "Bow":
                Damage = 10;
                attackspeed =2f;
                break;
            case "Daggers":
                Damage=5;
                attackspeed =2f;
                break;

        }
    }
    public void Attack()
    {
        IsHitting = true;
    }
}
