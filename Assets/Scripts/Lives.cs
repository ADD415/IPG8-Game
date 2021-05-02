using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    Image m_image;
    public Sprite TwoLives;
    public Sprite OneLife;
    public Sprite NoLives;
    public Sprite FullLives;

    void Start()
    {
        m_image = GetComponent<Image>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (UIManager.lives == 2)
        {
            m_image.sprite = TwoLives;
        }
        else if (UIManager.lives == 1)
        {
            m_image.sprite = OneLife;
        }
        else if (UIManager.lives == 0)
        {
            m_image.sprite = NoLives;
        }
        else
        {
            m_image.sprite = FullLives;
        }



    }
}
