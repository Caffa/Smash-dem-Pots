using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHit : MonoBehaviour
{

    public bool needText;
    public string questComplete;
    public GameObject text;
    public Text placeText; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Swung Sword - Hit other thing");
        if(other.CompareTag("breakable"))
        {
            Debug.Log("Told Pot to Smash itself");
            other.GetComponent<Pot>().Smash();
            KeepScore.Score += 1;
            // KeepScore.HP -= 25;
            KeepScore.EXP += 30;
            if (KeepScore.Score == 4)
            {
                if (needText){
                    StartCoroutine(questCompleteCo());
                }
            }
            
        }
    }

    private IEnumerator questCompleteCo()
    {
        text.SetActive(true);
        placeText.text = questComplete;
        yield return new WaitForSeconds(2f);
        text.SetActive(false);

    }
}
