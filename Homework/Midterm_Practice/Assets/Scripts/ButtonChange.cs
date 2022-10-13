using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonChange : MonoBehaviour
{
    public SpriteRenderer[] bgChange = new SpriteRenderer[5];
    private int _bgindex;

    public Renderer[] particleChange = new Renderer[5];
    private int _particleindex;

    public Renderer _p1;
    public Renderer _p2;
    public Renderer _p3;
    public Renderer _p4;
    public Renderer _p5;

    private SpriteRenderer _eichenwalde;
    private SpriteRenderer _hanamura;
    private SpriteRenderer _ilios;
    private SpriteRenderer _kingsrow;
    private SpriteRenderer _lijianggarden;

    //public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        bgChange[0] = GameObject.FindGameObjectWithTag("Eichenwalde").GetComponent<SpriteRenderer>();
        bgChange[1] = GameObject.FindGameObjectWithTag("Hanamura").GetComponent<SpriteRenderer>();
        bgChange[2] = GameObject.FindGameObjectWithTag("Ilios").GetComponent<SpriteRenderer>();
        bgChange[3] = GameObject.FindGameObjectWithTag("KingsRow").GetComponent<SpriteRenderer>();
        bgChange[4] = GameObject.FindGameObjectWithTag("LijiangGarden").GetComponent<SpriteRenderer>();

        particleChange[0] = GameObject.FindGameObjectWithTag("p1").GetComponent<Renderer>();
        particleChange[1] = GameObject.FindGameObjectWithTag("p2").GetComponent<Renderer>();
        particleChange[2] = GameObject.FindGameObjectWithTag("p3").GetComponent<Renderer>();
        particleChange[3] = GameObject.FindGameObjectWithTag("p4").GetComponent<Renderer>();
        particleChange[4] = GameObject.FindGameObjectWithTag("p5").GetComponent<Renderer>();

        _p1 = GameObject.FindGameObjectWithTag("p1").GetComponent<Renderer>();
        _p2 = GameObject.FindGameObjectWithTag("p2").GetComponent<Renderer>();
        _p3 = GameObject.FindGameObjectWithTag("p3").GetComponent<Renderer>();
        _p4 = GameObject.FindGameObjectWithTag("p4").GetComponent<Renderer>();
        _p5 = GameObject.FindGameObjectWithTag("p5").GetComponent<Renderer>();


        _eichenwalde = GameObject.FindGameObjectWithTag("Eichenwalde").GetComponent<SpriteRenderer>();
        _hanamura = GameObject.FindGameObjectWithTag("Hanamura").GetComponent<SpriteRenderer>();
        _ilios = GameObject.FindGameObjectWithTag("Ilios").GetComponent<SpriteRenderer>();
        _kingsrow = GameObject.FindGameObjectWithTag("KingsRow").GetComponent<SpriteRenderer>();
        _lijianggarden = GameObject.FindGameObjectWithTag("LijiangGarden").GetComponent<SpriteRenderer>();

        _p1.enabled = true;
        _p2.enabled = false;
        _p3.enabled = false;
        _p4.enabled = false;
        _p5.enabled = false;

        _eichenwalde.enabled = true;
        _hanamura.enabled = false;
        _ilios.enabled = false;
        _kingsrow.enabled = false;
        _lijianggarden.enabled = false;
    }

   
    public void BackgroundChange()
    {
        _bgindex++;

        if (_bgindex < bgChange.Length)
        {
            for (int i = 0; i < bgChange.Length; i++)
            {
                bgChange[i].enabled = false;
            }
            bgChange[_bgindex].enabled = true;

        }
        else
        {
            _bgindex = -1;
        }

    }

    public void ParticleChange()
    {
        _particleindex++;

        if (_particleindex < particleChange.Length)
        {
            for (int i = 0; i < particleChange.Length; i++)
            {
                particleChange[i].enabled = false;
            }
            particleChange[_particleindex].enabled = true;

        }
        else
        {
            _particleindex = -1;
        }
    }
}
