using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFXLIfeTimer : MonoBehaviour
{

    [SerializeField]
    private float timer = 3f;

    private void Start()
    {
        Destroy(gameObject, timer);
    }



}// class



