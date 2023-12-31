using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public GameObject GetCharacter(int id)
    {
        if (id == 0)
            return player1;
        else
            return player2;
    }
}
