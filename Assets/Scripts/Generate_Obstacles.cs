using UnityEngine;

public class Generate_Obstacles : MonoBehaviour
{
    public GameObject recyclable_1;
    public GameObject unrecyclable_1;
    public GameObject recyclable_2;
    int score = 0;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacleUnrecyclable", 1f, 2f);
        InvokeRepeating("CreateObstacleRecyclable", 1f, 2f);

    }

    // Update is called once per frame
    void OnGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label("Current Score: " + score.ToString());
    }

   
    void CreateObstacleRecyclable()
    {
        Invoke("CreateObstacleRecyclable_1", Random.Range(1,5));
        Invoke("CreateObstacleRecyclable_2", Random.Range(1, 5));
    }
    void CreateObstacleRecyclable_1()
    {
        if (recyclable_1 != null)
        {
            Instantiate(recyclable_1);
            score++;
        }
    }
    void CreateObstacleRecyclable_2()
    {
        if (recyclable_2 != null)
        {
            Instantiate(recyclable_2);
            score++;
        }
    }
    void CreateObstacleUnrecyclable_1()
    {
        if (unrecyclable_1 != null)
        {
            Instantiate(unrecyclable_1);
            score++;
        }
    }
    void CreateObstacleUnrecyclable(){
        Invoke("CreateObstacleUnrecyclable_1", Random.Range(1, 5));
    }
}