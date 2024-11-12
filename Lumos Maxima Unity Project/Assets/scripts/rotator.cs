using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotator : MonoBehaviour
{

    [Range(1, 10)]
    public float speed = 5;
    Camera cam;
    public RenderTexture rt;
    Texture2D texture;
    [UPyPlot.UPyPlotController.UPyProbe]
    public float c = 0;
    public float y;
    public float smoothness;
    Material mat;
    public Scrollbar sb,tb;
    


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        //texture = toTexture2D(rt);

       

    }
    Texture2D toTexture2D(RenderTexture rTex)
    {
        Texture2D tex = new Texture2D(256,256, TextureFormat.RGB24, false);
        // ReadPixels looks at the active RenderTexture.
        RenderTexture.active = rTex;
        tex.ReadPixels(new Rect(0, 0, rTex.width, rTex.height), 0, 0);
        tex.Apply();
        return tex;
    }
    

    // Update is called once per frame
    void Update()
    {

        mat = GetComponent<Renderer>().material;
        mat.SetFloat("_Glossiness", smoothness); // = smoothness;
        smoothness = sb.value;

      gameObject.transform.Rotate(0,speed * tb.value,0);


        RenderTexture.active = rt;
        Texture2D image = new Texture2D(rt.width, rt.height, TextureFormat.ARGB32, false);
        image.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
        image.Apply();
        RenderTexture.active = null;

        c = 0;
        for (int i = 0; i < 256; i++)
        {
            for (int j = 0; j < 256; j++)
            {
                c+= image.GetPixel(i,j).grayscale / 6000;
            }
        }
        y = gameObject.transform.rotation.y;
        // return c;
       // Debug.Log(transform.localEulerAngles);
       // Debug.Log(c/6000);

    }


}
