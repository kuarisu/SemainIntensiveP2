﻿using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour {

    private int m_PlayerID;
    private bool m_PlayerIsGrounded;


    private bool m_IsJumping = false;     //Définit si le Player est entrain de sauter ou non
    public float m_JumpCoolDown = 100f;
    private float m_JumpSpeed = 35f;

    void Start()
    {
        m_PlayerID = GetComponent<Player>().m_PlayerID;
       
    }

    void Update () {

        m_PlayerIsGrounded = GetComponent<PlayerGravity>().m_IsGrounded;
        //Jumping
        if (Input.GetButtonDown("A_" + m_PlayerID.ToString()))
        {

            StartCoroutine(Jumping());
        }
    }

    //Saut Simple, Penser à ménager pour un saut double et aussi au wall jump
    IEnumerator Jumping()
    {
       //Sauter tout le temps, mais y a un compteur et si il tombe à 0 on ne peut plus sauter (donc pas de limitation de saut SEULEMENT quand isGrounded. A voir)
        if (m_PlayerIsGrounded == false)
        {
            Debug.Log("hello false");

            yield return null; //Mettre le double saut ici ?
        }
        if (m_PlayerIsGrounded == true)
        {
            Debug.Log("hello true");
            m_IsJumping = true;
            #region Jump + changing gravity

            int _time = 15;
            for (int i = 0; i < _time; i++)
            {
                Debug.Log("Hello int");
               
                m_PlayerIsGrounded = true;
                transform.Translate((Vector3.up * m_JumpSpeed) * Time.smoothDeltaTime) ;
                yield return new WaitForEndOfFrame();
            }

            Debug.Log("hello end");
            m_PlayerIsGrounded = true;
            #endregion
            m_IsJumping = false;

        }

        yield return null;
    }
}
