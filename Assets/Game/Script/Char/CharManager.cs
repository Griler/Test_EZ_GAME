using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class CharManager : MonoBehaviour
{
    private IAnimation animationManager;
    // Start is called before the first frame update
    void Start()
    {
        animationManager = GetComponent<IAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
            Debug.Log(Input.touchCount);
            animationManager.PlayAnimation("Kidney Punch Right");
        }
    }
}
