using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextoFlotante : MonoBehaviour
{
    public float tiempo = 2;
    private Text label;
    // Start is called before the first frame update
    void Start()
    {
        label = GameObject.Find("TextLabel").GetComponent<Text>();
        label.text = "";
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        tiempo -= Time.deltaTime;
        string objeto = gameObject.name.ToString();
        if (objeto == "Headboard_1_1")
        {
            Application.OpenURL("http://localhost:4200/detalle/jampeu7ahNfq10z6yX4u");
        }
    }
    public void mensaje(string objeto)
    {
        tiempo -= Time.deltaTime;
        if (objeto == "velador1")
        {
            label.text = "velador color cafe \r\n medias \r\n altura: 1.25m ancho: 0.55m profundidad: 0.55m";
        }
        else if (objeto == "velador2")
        {
            label.text = "velador color cafe \r\n medias \r\n altura: 0.6m ancho: 0.55m profundidad: 0.55m";
        }
        else if (objeto == "cama1")
        {
            label.text = "cama color plomo \r\n medias \r\n altura: 0.5m ancho: 1.75m profundidad: 2.3m";
        }
        else if (objeto == "cama2")
        {
            label.text = "cama color celeste \r\n medias \r\n altura: 1m ancho: 1.75m profundidad: 2.4m";
        }
        else if (objeto == "cocina")
        {
            label.text = "mueble de cocina color blanco \r\n medias \r\n altura: 3m ancho: 3m profundidad: 0.55m";
        }else{
            label.text = " ";
        }
    }
    public void clean()
    {
        label.text = "";
    }

}
