using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Image mira;


    
    void Start()
    {
        

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        mira.rectTransform.position = Input.mousePosition;
    }
}
