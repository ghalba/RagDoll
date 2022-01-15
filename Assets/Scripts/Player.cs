using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float Speed;
    public int Armor;
    public int curr_health;
    public int Damage;
    public bool IsHitting=false;
    public GameObject Sword, Bow, Dagger, Arrow, LeatherArmor;
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
                LeatherArmor.SetActive(true);
                break;
            case "LArmor":
                Armor = 10;
                break;
            case "Sword":
                Damage = 30;
                Sword.SetActive(true);
                Bow.SetActive(false);
                Arrow.SetActive(false);
                Dagger.SetActive(false);
                break;
            case "Bow":
                Damage = 15;
                Bow.SetActive(true);
                Arrow.SetActive(true);
                Dagger.SetActive(false);
                Sword.SetActive(false);
                break;
            case "Daggers":
                Damage=25;
                Dagger.SetActive(true);
                Sword.SetActive(false);
                Arrow.SetActive(false);
                Bow.SetActive(false);
                break;

        }
    }
}
