using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

        // anim = gameGetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Smash()
    {
        // anim.SetBool("smash", true);
        anim.SetTrigger("smash-trigger");
        Debug.Log("Pot is smashed");
        StartCoroutine(breakCo());
    }

    IEnumerator breakCo()
    {
        // to wait then disappear??
        yield return new WaitForSeconds(.3f);
        this.gameObject.SetActive(false);
        // anim.SetBool("smash", false);
    }

}

