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
        if (m_rb)
        {
            m_rb.velocity = new Vector2 (-movingSpeed, m_rb.velocity.y);
        }

        if (atkDistance >= Vector2.Distance(m_rb.position, m_player.transform.position))
        {
            m_anim.SetBool(Const.ATTACK_ANIM, true);
            m_rb.velocity = Vector2.zero;
        }
    }
}
