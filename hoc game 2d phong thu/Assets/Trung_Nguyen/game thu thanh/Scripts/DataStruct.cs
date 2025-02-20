using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStruct : MonoBehaviour
{
    [System. Serializable]
    public class ShopItem
    {
        public Player playerPrefab;
        public int price;
        public Sprite previewImage;
    }
}
