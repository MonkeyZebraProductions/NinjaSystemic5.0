using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public List<Transform> Spawnpoints;
    public List<BoxCollider2D> collider2Ds;
    public static int index;
    public GameObject player;
    private Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(collider2Ds[index / 2]);
        player.transform.position = Spawnpoints[index / 2].position;
        timer=FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increment()
    {
        Destroy(collider2Ds[index/2]);
        index += 1;
        timer.Capture();
    }
}
