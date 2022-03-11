using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private void Start() 
    {   
           
    }


    private void Update() 
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;   

            if(Vector3.Distance(transform.position, Player.Instance.transform.position) > 130)
            {
                gameObject.SetActive(false);
            }

    }
}
