using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class iitem_collection : MonoBehaviour
{

    private int cherries = 0;
    public Text cherriesText;
   // private Text cherriesText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)

    
    {

        Debug.Log("Cherry");
        Debug.Log(collision.gameObject.CompareTag("Cherry"));
        if (collision.gameObject.CompareTag("Cherry"))
        {

            Debug.Log("Yes");
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Cherries: " + cherries;
        }
    }


}
