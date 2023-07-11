using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy1 : MonoBehaviour
{
    public float startSpeed = 10f;
    [HideInInspector]
    public float speed;

    public float startHealth = 300;

    private float health;

    public int worth = 50;

    [Header("Unity Stuff")]
    public Image healthBar;

    private Animator anim;
    private bool isDead = false;

    private void Start()
    {
        speed = startSpeed;
        health = startHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamege(float amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;

        if (health <= 0 && !isDead)
        {
            Die();
        }
    }

    public void Slow(float pct)
    {
        speed = startSpeed * (1f - pct);
    }

    void Die()
    {
        isDead = true;

        PlayerStats.Money += worth;

        WaveSpawner.EnemiesAlive--;

        if (anim != null)
        {
            anim.SetTrigger("Death"); 
        }


        Destroy(gameObject, 1f);
    }
}
