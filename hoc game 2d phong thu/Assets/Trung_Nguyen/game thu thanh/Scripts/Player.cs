using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator m_anim;
    public float atkRate;
    float curAtkRate;
    bool isAttacked;
    bool isDead;
    Rigidbody2D rb;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        m_anim = GetComponent<Animator>();
        curAtkRate = atkRate;
        rb = GetComponent<Rigidbody2D>();
        rb.transform.localScale =new Vector2(-1,1); 
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isAttacked)
        {
           if (m_anim)
            m_anim.SetBool(Const.ATTACK_ANIM, true);
            isAttacked = true;
        }

        if (isAttacked)
        {
            curAtkRate -= Time.deltaTime;
            if (curAtkRate < 0)
            {
                isAttacked = false;
                curAtkRate = atkRate;
            }
        }
    }

    public void ResetAttacking()
    {
        if (m_anim)
            m_anim.SetBool(Const.ATTACK_ANIM, false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Const.ENEMY_WEAPON_TAG) && !isDead)
        {
            m_anim.SetBool(Const.DEAD_ANIM, true);
            isDead = true;
        }
    }

    public bool IsDied()
    {
        return isDead;
    }

    public void AddScore (int score)
    {
        this.score += score;
        Debug.Log ("score: " + this.score);
    }
}
