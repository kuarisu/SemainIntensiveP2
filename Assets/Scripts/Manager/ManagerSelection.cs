﻿using UnityEngine;
using System.Collections;

public class ManagerSelection : MonoBehaviour {

    public GameObject PlayerOne;
    public GameObject PlayerTwo;
    public GameObject PlayerThree;
    public GameObject PlayerFour;

    public bool m_Slectionning = true;
    bool m_CanAdd_1 = true;
    bool m_CanAdd_2 = true;
    bool m_CanAdd_3 = true;
    bool m_CanAdd_4 = true;

    void Update()
    {
        //Select and deselect player 1
        if (m_Slectionning == true && Input.GetButtonDown("A_1") && m_CanAdd_1 == true)
        {
            ManagerSpawn.instance.m_Characters.Insert(0, PlayerOne);
            m_CanAdd_1 = false;
        }
        if (m_Slectionning == true && Input.GetButtonDown("B_1") && m_CanAdd_1 == false)
        {
            ManagerSpawn.instance.m_Characters.RemoveAt(0);
            m_CanAdd_1 = true;
        }

        //Select and deselect player 2
        if (m_Slectionning == true && Input.GetButtonDown("A_2") && m_CanAdd_2 == true)
        {
            ManagerSpawn.instance.m_Characters.Insert(1, PlayerTwo);
            m_CanAdd_2 = false;
        }
        if (m_Slectionning == true && Input.GetButtonDown("B_2") && m_CanAdd_2 == false)
        {
            ManagerSpawn.instance.m_Characters.RemoveAt(1);
            m_CanAdd_2 = true;
        }

        //Select and deselect player 3
        if (m_Slectionning == true && Input.GetButtonDown("A_3") && m_CanAdd_3 == true)
        {
            ManagerSpawn.instance.m_Characters.Insert(2, PlayerThree);
            m_CanAdd_3 = false;
        }
        if (m_Slectionning == true && Input.GetButtonDown("B_3") && m_CanAdd_3 == false)
        {
            ManagerSpawn.instance.m_Characters.RemoveAt(2);
            m_CanAdd_3 = true;
        }

        //Select and deselect player 3
        if (m_Slectionning == true && Input.GetButtonDown("A_4") && m_CanAdd_4 == true)
        {
            ManagerSpawn.instance.m_Characters.Insert(3, PlayerFour);
            m_CanAdd_4 = false;
        }
        if (m_Slectionning == true && Input.GetButtonDown("B_4") && m_CanAdd_4 == false)
        {
            ManagerSpawn.instance.m_Characters.RemoveAt(3);
            m_CanAdd_4 = true;
        }
    }

}