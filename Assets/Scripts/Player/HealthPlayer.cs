using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public int CurrentHealth = 6;
    public GameObject[] Hearts;
    AudioSource AS;
    public  AudioClip takedmgclip;

    bool IsShield = false;
    public void TakeDmg()
    {
        if (!IsShield)
        {
            CurrentHealth--;
            CheckHealth();
            AS.PlayOneShot(takedmgclip);
            StartCoroutine(Shield());
        }
    }
    private void Start()
    {
     AS =  gameObject.GetComponent<AudioSource>();
    }

    void CheckHealth()
    {
        switch (CurrentHealth)//времени мало , ничего лучше не придумал
        {
            case 5:
                Hearts[2].transform.GetChild(1).gameObject.SetActive(true);
                Hearts[2].transform.GetChild(0).gameObject.SetActive(false);
                break;
            case 4:
                Hearts[2].transform.GetChild(1).gameObject.SetActive(false);
                break;
            case 3:
                Hearts[1].transform.GetChild(0).gameObject.SetActive(false);
                Hearts[1].transform.GetChild(1).gameObject.SetActive(true);
                break;
            case 2:
                Hearts[1].transform.GetChild(1).gameObject.SetActive(false);
                break;
            case 1:
                Hearts[0].transform.GetChild(0).gameObject.SetActive(false);
                Hearts[0].transform.GetChild(1).gameObject.SetActive(true);
                break;
            case 0:
                //Перезапуск уровня!!!
                break;
        }
    }

    IEnumerator Shield()
    {
        IsShield = true;
       
            yield return new WaitForSeconds(.2f);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        
            yield return new WaitForSeconds(.2f);
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
    
            yield return new WaitForSeconds(.2f);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        
            yield return new WaitForSeconds(.2f);
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
         
            yield return new WaitForSeconds(.2f);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        
            yield return new WaitForSeconds(.2f);
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
           
            IsShield = false;
            StopCoroutine(Shield());
        
       
    }
}
