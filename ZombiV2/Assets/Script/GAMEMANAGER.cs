using UnityEngine;

public class GAMEMANAGER : MonoBehaviour
{
    public GameObject selectedZombie;

    public GameObject[] zombies;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(zombies[2].name);
        selectedZombie = zombies[2];
        Debug.Log("selected:" + selectedZombie.name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}