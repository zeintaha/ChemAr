using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public Scene mScene;
    public static int scoreToUpdate;
    public Button NextButton;
    public Text ScoreText;
   private bool gameOver;
    int Score;

    //private GameObject go;
    public GameObject ho;
    private GameObject heo;
    private GameObject oo;
    private GameObject co;
    private GameObject cuo;
    private GameObject mgo;
    private GameObject ko;
    private GameObject alo;
    private GameObject ago;
    private GameObject lio;



    void Start()
    {

        gameOver = false;
       Score = scoreToUpdate;
        InvokeRepeating("ScoreUpdate", 1.0f, 0.5f);
        mScene = SceneManager.GetActiveScene();
      // go = GameObject.FindWithTag("model");
       ho = GameObject.FindWithTag("h");
       heo = GameObject.FindWithTag("he");
       oo = GameObject.FindWithTag("o");
       co = GameObject.FindWithTag("c");
       cuo = GameObject.FindWithTag("cu");
       mgo = GameObject.FindWithTag("mg");
       ko = GameObject.FindWithTag("k");
       alo = GameObject.FindWithTag("al");
       ago = GameObject.FindWithTag("ag");
       lio = GameObject.FindWithTag("li");
       ho.gameObject.SetActive(false);
       heo.gameObject.SetActive(false);
       oo.gameObject.SetActive(false);
       co.gameObject.SetActive(false);
       cuo.gameObject.SetActive(false);
       mgo.gameObject.SetActive(false);
       ko.gameObject.SetActive(false);
       alo.gameObject.SetActive(false);
       ago.gameObject.SetActive(false);
       lio.gameObject.SetActive(false);
}

public void Update()
    {
#pragma warning disable 27
        //  ScoreText.text = "Score: " + Score.ToString();
        //go.transform.rotation = Quaternion.Euler(0f, 180 * Mathf.Sin(Time.time * 2), 0f);
        ho.transform.rotation = Quaternion.Euler(0f, 180 * Mathf.Sin(Time.time * 2), 0f);
        heo.transform.rotation = Quaternion.Euler(0f, 180 * Mathf.Sin(Time.time * 2), 0f);
        oo.transform.rotation = Quaternion.Euler(0f, 180 * Mathf.Sin(Time.time * 2), 0f);
        co.transform.rotation = Quaternion.Euler(0f, 180 * Mathf.Sin(Time.time * 2), 0f);
        cuo.transform.rotation = Quaternion.Euler(0f, 180 * Mathf.Sin(Time.time * 2), 0f);
        mgo.transform.rotation = Quaternion.Euler(0f, 180 * Mathf.Sin(Time.time * 2), 0f);
        ko.transform.rotation = Quaternion.Euler(0f, 180 * Mathf.Sin(Time.time * 2), 0f);
        alo.transform.rotation = Quaternion.Euler(0f, 180 * Mathf.Sin(Time.time * 2), 0f);
        ago.transform.rotation = Quaternion.Euler(0f, 180 * Mathf.Sin(Time.time * 2), 0f);
        lio.transform.rotation = Quaternion.Euler(0f, 180 * Mathf.Sin(Time.time * 2), 0f);

    }

  
    void ScoreUpdate()
    {
        if (mScene.name == "Chem")
        {
            if (gameOver == false)
            {
                Score += 1;
            }

            scoreToUpdate = Score;

        }
       
    }
    
    public void gameOverActivated()
    {
        gameOver = true;
        NextButton.gameObject.SetActive(false);
       
    }

  
    // scene control
    public void Menu()
    {
        SceneManager.LoadScene("ChemARMenu");

    }
    public void Scene3()
    {
        SceneManager.LoadScene("ChemAR3");
        scoreToUpdate = 0;
    }

    public void Scene2()
    {
        SceneManager.LoadScene("ChemAR2");
    }

    public void Scene1()
    {
        SceneManager.LoadScene("ChemAR1");
    }


    public void Exit()
    {
        Application.Quit();
    }
    // activate 3d models
    public void H()
    {
       ho.gameObject.SetActive(true);
    }
    public void He()
    {
        heo.gameObject.SetActive(true);
    }
    public void O()
    {
        oo.gameObject.SetActive(true);
    }public void Li()
    {
        lio.gameObject.SetActive(true);
    }public void C()
    {
        co.gameObject.SetActive(true);
    }public void Cu()
    {
        cuo.gameObject.SetActive(true);
    }public void Mg()
    {
        mgo.gameObject.SetActive(true);
    }public void Al()
    {
        alo.gameObject.SetActive(true);
    }public void Ag()
    {
        ago.gameObject.SetActive(true);
    }public void K()
    {
        ko.gameObject.SetActive(true);
    }
    // activate button links
    public void hLink()
    {
        Application.OpenURL("https://www.lenntech.com/periodic/elements/h.htm");
    }
    public void heLink()
    {
        Application.OpenURL("https://www.lenntech.com/periodic/elements/he.htm");
    }
    public void liLink()
    {
        Application.OpenURL("https://www.lenntech.com/periodic/elements/li.htm");
    }
    public void beLink()
    {
        Application.OpenURL("https://www.lenntech.com/periodic/elements/be.htm");
    }
    public void bLink()
    {
        Application.OpenURL("https://www.lenntech.com/periodic/elements/b.htm");
    }
    public void cLink()
    {
        Application.OpenURL("https://www.lenntech.com/periodic/elements/c.htm");
    }
    public void nLink()
    {
        Application.OpenURL("https://www.lenntech.com/periodic/elements/n.htm");
    }
    public void oLink()
    {
        Application.OpenURL("https://www.lenntech.com/periodic/elements/o.htm");
    }
    public void fLink()
    {
        Application.OpenURL("https://www.lenntech.com/periodic/elements/f.htm");
    }
    public void neLink()
    {
        Application.OpenURL("https://www.lenntech.com/periodic/elements/ne.htm");
    }
}
