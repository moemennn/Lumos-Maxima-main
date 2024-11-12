using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curve : MonoBehaviour
{
    // Start is called before the first frame update
    public rotator rot;
    public float g = 0;
    public Camera cam;
    [Range(-10, 10)]
    public float intensity = 1;
    float f = 0;
    public float x = 10;

    void Start()
    {
          
      //  gameObject.transform.position = new Vector3(Time.time, rot.c);  
    }

    // Update is called once per frame
    void Update()
    {
        g+= rot.speed * rot.tb.value;
       
       
        Vector3 v = cam.WorldToViewportPoint(gameObject.transform.position);

        // if (v.x >= 1 || v.y >= 1)
        //   g = 0;
        //  Debug.Log(rot.transform.eulerAngles);
        
        f += 1f * rot.tb.value;
        if (g >= 360)
        { g = 0;
            f = 0;
            Debug.Log("full irlc ");
        }
        

        gameObject.transform.position = new Vector3(g/x, rot.c * intensity);
    }
    
}
