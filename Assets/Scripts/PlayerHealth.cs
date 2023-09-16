using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public double hydration;
    public double energy;

    void Awake()
    {
        health = 100;
        hydration = 100;
        energy = 100;
    }
    void Update()
    {
        PlayerDead();
        Dehydration();
        Fatigue();
    }
    void OnCollisionEnter(Collision otherObj)
    {
        if(otherObj.gameObject.tag == "Enemy")
        {
            Debug.Log("Se ha perdido vida");
            health = health - 10;
            Destroy(otherObj.gameObject);
        }

        if (otherObj.gameObject.tag == "Health")
        {
            Debug.Log("Se gano puntos vitales y de energia");
            health += 10;
            energy += 15;
            Destroy(otherObj.gameObject);
        }
    }
    private void Dehydration()
    {
        hydration -= 0.1 * Time.deltaTime;
        if (hydration <= 0)
        {
            health -= 10 * Time.deltaTime;
        }
    }
    private void Fatigue()
    {
        CostPerAction();
        if (energy  <= 0)
        {
            Debug.Log("No da mas. No puede realizar otra accion");
        }
    }
    private void CostPerAction()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            energy -= 1;
        }
    }
    private void PlayerDead()
    {
        if (health <= 0)
        {
            Debug.Log("Se muriooooo");
        }
    }
}
