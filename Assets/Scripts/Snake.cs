using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Snake : MonoBehaviour
{
    private Vector3 nextPos;
    public Text gameOverText;
    private double score;
    public Text pts;
    enum Direction
    {
        //up, down, left,right
        right, up, down, left
    }

    
    Direction direction;
    public List<Transform> Tail= new List<Transform>();

    public float frameRate = 0.2f;

    public float step = 1;

    private int contador = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        
        for (int i = 0; i < Tail.Count; i++)
        {
            Tail[i].gameObject.SetActive(false);
        }
        InvokeRepeating("Move", frameRate, frameRate);
    }

    void Move()
    {
        //body.pos = nextPos;
        //Vector3 nextPos = Vector3.zero;
        lastPos = transform.position;
            nextPos = Vector3.zero;
        if (direction == Direction.up)
            //nextPos = Vector3.up;
            nextPos = new Vector3(0, 0, 1);
        else if (direction == Direction.down)
            //nextPos = Vector3.down;
            nextPos = new Vector3(0, 0, -1);
        else if (direction == Direction.left)
            nextPos = Vector3.left;
        else if (direction == Direction.right)
            nextPos = Vector3.right;
        nextPos *= step;
        transform.position += nextPos;
        MoveTail();
    }

    private Vector3 lastPos;
    void MoveTail()
    {
        for (int i = 0; i < Tail.Count; i++)
        {
            Vector3 temp = Tail[i].position;
            Tail[i].position = lastPos;
            lastPos = temp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            direction = Direction.up;
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            direction = Direction.down;
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            direction = Direction.left;
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            direction = Direction.right;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
        {
            Tail[contador].gameObject.SetActive(true);
            contador++;
            
            score = score + 1;
            print(score);
            actPts();
        }
        else if (other.tag == "Wall")
        {
            print("Pareeeeeeed");
            gameOverText.gameObject.SetActive(true);
            transform.position *= 0;
        }
    }
    
    void actPts()
    {
        pts.text = "Score = " + score.ToString();
    }
}
