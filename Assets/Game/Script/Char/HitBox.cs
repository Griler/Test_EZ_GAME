using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ví dụ script gắn vào hitbox tay phải
public class Hitbox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            var anim = other.GetComponent<IAnimation>();
            if (anim != null)
            {
                Debug.Log("dsds");
                gameObject.SetActive(false);
            }
            
        }
    }
}
