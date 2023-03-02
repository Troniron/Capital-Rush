using UnityEngine;
using UnityEngine.SceneManagement;


// This Assaiment for Capital Rush,
//Date=02/03/2023.


public class GameManager : MonoBehaviour
{


   
    float SmallLight = 2.1f;
    [SerializeField]
    int Hight = 8, Whight = 5;
 

    private void Start()
    {
        //Genratting the Function On Random Value
        int gameload = Random.Range(1, 9);
        if (gameload % 3 == 0) Generator1();
        if (gameload % 3 == 1) Generator2();
        if (gameload % 3 == 2) Generator3();


    }
   
    private void Generator1()
    {
        GameObject resourse = (GameObject)Instantiate(Resources.Load("parent"));
        GameObject resourse2 = (GameObject)Instantiate(Resources.Load("Bulp_2"));
        for (int i = 0; i < Whight; i++)
        {
            for (int x = 0; x < Hight; x++)
            {

                GameObject grid = (GameObject)Instantiate(resourse, transform);


                float pox = x * SmallLight;
                float poy = i * -SmallLight;
                grid.transform.position = new Vector2(pox, poy);
                if (x == 1 && i == 1)
                {
                   
                    GameObject grid1 = (GameObject)Instantiate(resourse2, transform);
                    float pos2 = SmallLight;
                    float pos2y = -SmallLight;
                    
                    grid1.transform.position = new Vector2(pos2, pos2y);
              
                }
                else if (x == 2 && i == 2)
                {

                    GameObject grid1 = (GameObject)Instantiate(resourse2, transform);
                    float pos2 = 2.1f;

                    float pos2y = -0.01f;


                    grid1.transform.position = new Vector2(pos2, pos2y);
                    grid1.transform.Rotate(new Vector3(0f, 0, -90f));

                }


            }

        }
        Destroy(resourse);

        Destroy(resourse2);
        float gritrow = Hight * SmallLight;
        float grithi = Whight * SmallLight;
        //Allaign the Position On The grid Distance
        transform.position = new Vector2(-gritrow / 2 + SmallLight, grithi / 2 - SmallLight / 2);
    }

    private void Generator2()
    {
        GameObject resourse = (GameObject)Instantiate(Resources.Load("parent"));
        GameObject resourse2 = (GameObject)Instantiate(Resources.Load("Bulp_2"));
        for (int i = 0; i < Whight; i++)
        {
            for (int x = 0; x < Hight; x++)
            {

                GameObject grid = (GameObject)Instantiate(resourse, transform);


                float pox = x * SmallLight;
                float poy = i * -SmallLight;
                grid.transform.position = new Vector2(pox, poy);
                if (x == 1 && i == 1)
                {
                    
                    GameObject grid1 = (GameObject)Instantiate(resourse2, transform);
                    float pos2 = 0.02f;
                    float pos2y = -2.14f;
                  
                    grid1.transform.position = new Vector2(pos2, pos2y);
                  
                }
                else if (x == 2 && i == 2)
                {

                    GameObject grid1 = (GameObject)Instantiate(resourse2, transform);
                    float pos2 = 4.18f;

                    float pos2y = -0.01f;


                    grid1.transform.position = new Vector2(pos2, pos2y);
                    grid1.transform.Rotate(new Vector3(0f, 0, -90f));

                }


            }

        }
        Destroy(resourse);

        Destroy(resourse2);
        float gritrow = Hight * SmallLight;
        float grithi = Whight * SmallLight;
        //Allaign the Position On The grid Distance
        transform.position = new Vector2(-gritrow / 2 + SmallLight, grithi / 2 - SmallLight / 2);

    }
    private void Generator3()
    {
        GameObject resourse = (GameObject)Instantiate(Resources.Load("parent"));
        GameObject resourse2 = (GameObject)Instantiate(Resources.Load("Bulp_2"));
        for (int i = 0; i < Whight; i++)
        {
            for (int x = 0; x < Hight; x++)
            {

                GameObject grid = (GameObject)Instantiate(resourse, transform);


                float pox = x * SmallLight;
                float poy = i * -SmallLight;
                grid.transform.position = new Vector2(pox, poy);
                if (x == 1 && i == 1)
                {
                   
                    GameObject grid1 = (GameObject)Instantiate(resourse2, transform);
                    float pos2 = -0.03f;
                    float pos2y = -0.04f;
                   
                    grid1.transform.position = new Vector2(pos2, pos2y);
                   
                }
                else if (x == 2 && i == 2)
                {

                    GameObject grid1 = (GameObject)Instantiate(resourse2, transform);
                    float pos2 = 4.2f;
                    float pos2y = -4.19f;


                    grid1.transform.position = new Vector2(pos2, pos2y);
                    grid1.transform.Rotate(new Vector3(0f, 0, -90f));

                }


            }

        }
        Destroy(resourse);

        Destroy(resourse2);
        float gritrow = Hight * SmallLight;
        float grithi = Whight * SmallLight;
        //Allaign the Position On The grid Distance
        transform.position = new Vector2(-gritrow / 2 + SmallLight, grithi / 2 - SmallLight / 2);

    }
    public void Button()
    {
        Debug.Log("Game Reloaded");
      //Restrat Everytime
        SceneManager.LoadScene("Scene1");
       
    }
 



}

