using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallCamera : MonoBehaviour
{
    public Vector3 offset;
    public Transform target;
    public float speed = 0.125f;


    public int width = 200;
    public int height = 150;
    public float xOffset = 0f;
    public float yOffset = 0f;
    private int hsize, vsize;


    private float hloc;
    private float vloc;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    private void FixedUpdate()
    {
        hsize = width;
        vsize = height;

        Vector3 positon1 = target.position+offset;
        Vector3 positon2 = Vector3.Lerp(transform.position, positon1, speed);
        transform.position = positon2;

        hloc = Mathf.RoundToInt(xOffset * 0.01f * Screen.width);
        vloc = Mathf.RoundToInt((Screen.height - vsize) - (yOffset * 0.01f * Screen.height));
        GetComponent<Camera>().pixelRect = new Rect(hloc, vloc, hsize, vsize);
        transform.LookAt(target);

    }
}
