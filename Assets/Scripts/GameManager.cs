using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Rigidbody mainBall;
    public float impulseForce = 10f;

    public void StartGame()
    {
        mainBall.AddForce(Vector3.forward * impulseForce, ForceMode.Impulse);
    }
}
