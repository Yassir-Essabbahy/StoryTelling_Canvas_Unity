using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Story_Telling_Manager : MonoBehaviour
{
    public GameObject[] Txts;
    public Canvas storyCanvas;

    void Start()
    {
        StartCoroutine(TellStory_Co());
    }

    IEnumerator TellStory_Co()
    {

        yield return new WaitForSeconds(1f);
        Txts[0].SetActive(true);

        yield return new WaitForSeconds(0.1f);

        yield return PressAnyKey_CO();
        Txts[1].SetActive(true);
        
        yield return new WaitForSeconds(0.1f);

        yield return PressAnyKey_CO();
        Txts[2].SetActive(true);
        
        

        yield return new WaitForSeconds(0.1f);
        yield return PressAnyKey_CO();


        SceneManager.LoadScene("MainMenu");
    }

    IEnumerator PressAnyKey_CO()
    {
        while (!Input.anyKeyDown)
        {
            yield return null;
        }

    }   
    


    
}
