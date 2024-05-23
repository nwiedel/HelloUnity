using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloGameObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 laufweite = new Vector3(1f, 0f, 0f);
        //transform.position += laufweite;

        Debug.Log(this.gameObject.name + " steht bei " + transform.position + 
            " local " + transform.localPosition);

        Debug.Log(this.gameObject.name + " scaliert " + transform.lossyScale +
            " local " + transform.localScale);
        // new GameObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
