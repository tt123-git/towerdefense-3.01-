using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 70f;

    public int damage = 50;

    public float explosionRadius = 0f;
    public GameObject bulletImpact;

    //Make gun effect is next task and fix instantiate
    public void Seek(Transform _target)
    {
        target = _target;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        
        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        //transform.LookAt(target); 
    }
    void HitTarget()
    {
        GameObject effectIns = (GameObject)Instantiate(bulletImpact, transform.position, transform.rotation);
        Destroy(effectIns, 1f);

        if(explosionRadius > 0f) 
        {
            Explode();
        }
        else
        {
            Damage(target);
        }
        //Destroy(target.gameObject);
        Destroy(gameObject);
    }

    void Explode()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, explosionRadius);
        foreach(Collider2D collider in colliders) 
        {
            if(collider.tag == "Enemy")
            {
                Damage(collider.transform);
            } 
        }
    }

    void Damage(Transform enemy)
    {
        Enemy1 e = enemy.GetComponent<Enemy1>();

        if (e != null) 
        {
            e.TakeDamege(damage);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }
}
