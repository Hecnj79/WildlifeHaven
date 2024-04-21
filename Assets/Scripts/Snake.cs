using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    private Vector2 _direction = Vector2.right;
    private List<Transform> _segments = new List<Transform>();
    public Transform segmentPrefab;
    public int initialSize = 4;

    private GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
        SnakeSize();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _direction = Vector2.down;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _direction = Vector2.right;
        }
    }

    private void FixedUpdate()
    {
        Time.fixedDeltaTime = 0.06f;

        for(int i = _segments.Count - 1; i > 0; i--)
        {
            _segments[i].position = _segments[i - 1].position;
        }

        this.transform.position = new Vector3(Mathf.Round(this.transform.position.x) + _direction.x, Mathf.Round(this.transform.position.y) + _direction.y, 0.0f);
    }

    private void Grow()
    {
        Transform segment = Instantiate(this.segmentPrefab);
        segment.position = _segments[_segments.Count - 1].position;

        _segments.Add(segment);
    }

    private void SnakeSize()
    {
        _segments.Add(this.transform);

        for(int i = 1; i < this.initialSize; i++)
        {
            _segments.Add(Instantiate(this.segmentPrefab));
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0f;
        gm.gameOverMenu.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Animal"))
        {
            Grow();
        }
        else if(collision.CompareTag("Obstacle"))
        {
            GameOver();
        }
    }
}
