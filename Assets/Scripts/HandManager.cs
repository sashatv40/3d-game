using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour
{

    public KeyCode albumCode = KeyCode.P;
    public KeyCode cameraCode = KeyCode.U;
    public Animator animatorAlbum;
    public Animator animatorCamera;
    private bool isAlbumActive = false;
    private bool isCameraActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(albumCode))
        {
            if (animatorAlbum.GetBool("open_y_close") == false && isCameraActive == false)
            {
                animatorAlbum.SetBool("open_y_close", true);
                isAlbumActive = true;
            }
            else
            {
                animatorAlbum.SetBool("open_y_close", false);
                isAlbumActive = false;
            }
        }
        
        
        if (Input.GetKeyDown(cameraCode))
        {
            if (animatorCamera.GetBool("PUT") == false && isAlbumActive == false)
            {
                animatorCamera.SetBool("PUT", true);
                isCameraActive = true;
            }
            else
            {
                animatorCamera.SetBool("PUT", false);
                isCameraActive = false;
            }
        }
    }
}