using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion : MonoBehaviour
{
    Animator animacion;
    // Start is called before the first frame update
    void Awake()
    {
        animacion = GetComponent<animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool caminar = Input.GetKey(KeyCode.LefyControl);
        animacion.SetBool("Caminar", caminar);

        if(Input.Input.GetKey(KeyCode.Space))
        {
            animacion.SetTrigger("ataque");
        }
  
    }
}
