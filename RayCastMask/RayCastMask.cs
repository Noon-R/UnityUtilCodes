using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]

public class RayCastMask : MonoBehaviour, ICanvasRaycastFilter {
                                                                //透過画像のボタンを作るときにアタッチすればオケ
    private Image _image;

    private Sprite _sprite;



    void Start() {

        _image = GetComponent<Image>();

    }



    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) {

        _sprite = _image.sprite;

        int x = Mathf.FloorToInt(sp.x / Screen.width  * _sprite.texture.width);
        int y = Mathf.FloorToInt(sp.y / Screen.height * _sprite.texture.height);

        return _sprite.texture.GetPixel(x,y).a > 0;

    }

}

