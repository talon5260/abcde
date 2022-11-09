using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColorChange : MonoBehaviour
{

    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "Ball") || (collision.gameObject.name == "Cylinder")
            || (collision.gameObject.name == "Cylinder (1)")
            || (collision.gameObject.name == "Cylinder (2)")
            || (collision.gameObject.name == "Cylinder (3)")
            || (collision.gameObject.name == "Cylinder (4)")
            || (collision.gameObject.name == "Cylinder (5)")
            || (collision.gameObject.name == "Cylinder (6)")
            || (collision.gameObject.name == "Cylinder (7)")
            || (collision.gameObject.name == "Cylinder (8)")
            || (collision.gameObject.name == "Cylinder9"))
        {
            mat.color = new Color(0, 0, 0);
            //new WaitForSeconds(0.3f);
        }

    }
    //private void OnCollisionExit(Collision collision)
    //{
    //    //if (collision.gameObject.name == "Ball")
    //    //    mat.color = new Color(1, 1, 1);

    //}
}
