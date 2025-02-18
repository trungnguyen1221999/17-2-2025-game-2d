using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator m_anim;
    public float atkRate;
    float curAtkRate;
    bool isAttacked;
    // Start is called before the first frame update
    void Start()
    {
        m_anim = GetComponent<Animator>();
        curAtkRate 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           if (m_anim)
            m_anim.SetBool(Const.ATTACK_ANIM, true);
        }
    }

    public void ResetAttacking()
    {
        if (m_anim)
            m_anim.SetBool(Const.ATTACK_ANIM, false);
    }
}
