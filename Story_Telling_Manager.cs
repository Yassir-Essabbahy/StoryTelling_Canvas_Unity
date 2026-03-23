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
        Txts[3].SetActive(true);
        
        yield return new WaitForSeconds(0.1f);

        yield return PressAnyKey_CO();
        Txts[4].SetActive(true);
        
        yield return new WaitForSeconds(0.1f);
        yield return PressAnyKey_CO();

        Txts[0].SetActive(false);
        Txts[1].SetActive(false);
        Txts[2].SetActive(false);
        Txts[3].SetActive(false);
        Txts[4].SetActive(false);
        Txts[5].SetActive(true);

        yield return new WaitForSeconds(0.05f);
        yield return PressAnyKey_CO();

        Txts[5].SetActive(false);

        SceneManager.LoadScene("develop2");
    }

    IEnumerator PressAnyKey_CO()
    {
        while (!Input.anyKeyDown)
        {
            yield return null;
        }

    }   
    


    
}
