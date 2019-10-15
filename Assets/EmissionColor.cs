using UnityEngine;

public class EmissionColor : MonoBehaviour
{
    int count = 0;
    Material mat;
    GameObject go;
    Light lt;
    private void Start()
    {
        mat = GetComponent<Renderer>().material;
        go = GetComponent<Renderer>().gameObject;
        lt = GetComponent<Light>();
        mat.EnableKeyword("_EMISSION");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a")) {
            if (count < 5)
            {
                count++;
                Debug.Log(count);
                for (int i = 0; i < 10; i++)
                {
                    go.transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
                    lt.intensity += 0.005f;
                }
                //mat.SetColor("_EmissionColor", Color.white);
            }
        }
    }
}
