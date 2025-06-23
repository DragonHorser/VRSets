using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class denglu : MonoBehaviour
{
    public Sprite xnormalImage;  // Ä¬ÈÏ×´Ì¬µÄÍ¼Æ¬
    public Sprite xpressedImage; // µã»÷×´Ì¬µÄÍ¼Æ¬
    public Sprite lnormalImage;  // Ä¬ÈÏ×´Ì¬µÄÍ¼Æ¬
    public Sprite lpressedImage; // µã»÷×´Ì¬µÄÍ¼Æ¬
    public Sprite knormalImage;  // Ä¬ÈÏ×´Ì¬µÄÍ¼Æ¬
    public Sprite kpressedImage; // µã»÷×´Ì¬µÄÍ¼Æ¬

    public Button xuexi_but, lianxi_but,kaohe_but;
    // Start is called before the first frame update
    void Start()
    {
        xuexi_but = GameObject.Find("Canvas/Image/Button (xue)").GetComponent<Button>();
        lianxi_but= GameObject.Find("Canvas/Image/Button (lian) ").GetComponent<Button>();
        //kaohe_but = GameObject.Find("Canvas/Image/Button (kao)").GetComponent<Button>();
        xuexi_but.onClick.AddListener(Onxuexi);
        lianxi_but.onClick.AddListener(Onlianxi);
        //kaohe_but.onClick.AddListener(Onkao);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Onxuexi()
    {
        //SceneManager.LoadScene("HeadScenen");
        //if (xuexi_but.image.sprite == xnormalImage)
        //{
        //    xuexi_but .image.sprite = xpressedImage;
        //}
        //else
        //{
        //   xuexi_but .image.sprite = xnormalImage;
        //}
    }
    public void Onlianxi()
    {
        SceneManager.LoadScene("lianximoshi_scene");
        if (lianxi_but .image.sprite == lnormalImage)
        {
            lianxi_but .image.sprite = lpressedImage;
        }
        else
        {
            lianxi_but .image.sprite = lnormalImage;
        }
    }

    //public void Onkao()
    //{
    //    if (kaohe_but .image.sprite == knormalImage)
    //    {
    //        kaohe_but .image.sprite = kpressedImage;
    //    }
    //    else
    //    {
    //       kaohe_but .image.sprite = knormalImage;
    //    }
    //}
}
