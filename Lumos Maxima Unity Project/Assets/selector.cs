using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class selector : MonoBehaviour
{
    public GameObject asteroid, teapot, astronaut, vesta;
    public GameObject current;
    public curve curve;
    public Scrollbar sb, tb;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void LoadAsteroid()
    {
        Destroy(current);
        current = Instantiate(asteroid, Vector3.zero, Quaternion.identity);
        curve.rot = current.GetComponent<rotator>();
        curve.g = 0;
        current.GetComponent<rotator>().enabled = true;
        current.GetComponent<MeshDeformer>().enabled = true;
        current.GetComponent<rotator>().sb = sb;
        current.GetComponent<rotator>().tb = tb;
    }
    public void LoadAstronaut()
    {
        Destroy(current);
        current = Instantiate(astronaut, Vector3.zero, Quaternion.identity);
        curve.rot = current.GetComponent<rotator>();
        curve.g = 0;
        current.GetComponent<rotator>().enabled = true;
        current.GetComponent<MeshDeformer>().enabled = true;
        current.GetComponent<rotator>().sb = sb;
        current.GetComponent<rotator>().tb = tb;
    }

    public void LoadTeapot()
    {

        Destroy(current);
        current = Instantiate(teapot, Vector3.zero, Quaternion.identity);
        curve.rot = current.GetComponent<rotator>();
        curve.g = 0;
        current.GetComponent<rotator>().enabled = true;
        current.GetComponent<MeshDeformer>().enabled = true;
        current.GetComponent<rotator>().sb = sb;
        current.GetComponent<rotator>().tb = tb;
    }
    public void LoadVesta()
    {
        Destroy(current);
        current = Instantiate(vesta, Vector3.zero, Quaternion.identity);
        curve.rot = current.GetComponent<rotator>();
        curve.g = 0;
        current.GetComponent<rotator>().enabled = true;
        current.GetComponent<MeshDeformer>().enabled = true;
        current.GetComponent<rotator>().sb = sb;
        current.GetComponent<rotator>().tb = tb;

    }

    public void Resetobject()
    {
        if (current.tag == "asteroid")
        {
            Destroy(current);
            current = Instantiate(asteroid, Vector3.zero, Quaternion.identity);
        }
        else if (current.tag == "teapot")
        {
            Destroy(current);
            current = Instantiate(teapot, Vector3.zero, Quaternion.identity);

        }
            
        else if (current.tag == "astronaut")
        {
            Destroy(current);
            current = Instantiate(astronaut, Vector3.zero, Quaternion.identity);
        }
        else if(current.tag == "kleo")
        {
            Destroy(current);
            current = Instantiate(vesta, Vector3.zero, Quaternion.identity);
        }
            
        
        curve.rot = current.GetComponent<rotator>();
        curve.g = 0;
        current.GetComponent<rotator>().enabled = true;
        current.GetComponent<MeshDeformer>().enabled = true;
        current.GetComponent<rotator>().sb = sb;
        current.GetComponent<rotator>().tb = tb;


    }



}
