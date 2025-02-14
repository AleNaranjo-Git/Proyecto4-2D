using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 move;

    void Start()
    {
        move = transform.position - player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + move;
    }
}