using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float movingSpeed;
    public float atkDistance;
    Rigidbody2D m_rb;
    Animator m_anim;
    Player m_player;

    void Start ()
    {
        m_rb = GetComponent<Rigidbody2D>();
        m_anim = GetComponent<Animator>();
        m_player = FindObjectOfType<Player>();

    }

    void Update()
    {
        float distanceToPlayer = Vector2.Distance(m_rb.position, m_player.transform.position);
        if (atkDistance >= distanceToPlayer)
        {
            m_anim.SetBool(Const.ATTACK_ANIM, true);
            m_rb.velocity = Vector2.zero;
        }
        else
            m_rb.velocity = new Vector2(-movingSpeed, m_rb.velocity.y);

    }

    public void Die()
    {
        m_anim.SetTrigger(Const.DEAD_ANIM);
        m_rb.velocity = Vector2.zero;   
        gameObject.layer = LayerMask.NameToLayer(Const.DEAD_LAYER);
    }
}
