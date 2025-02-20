using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DataStruct;

public class ShopManager : MonoBehaviour
{
    public ShopItem[] item;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    
    public void Init()
    {
        if (item == null || item.Length <= 0) return;
        for (int i = 0; i < item.Length; i++)
        {
            var Item = item[i];
            string dataKey = Const.PLAYER_PREFIX_PREF + i;
            if (Item != null)
            {
                if (i == 0)
                {
                    Pref.SetBool(dataKey, true);   
                }
                else
                {
                     if (!PlayerPrefs.HasKey(dataKey))
                    {
                        Pref.SetBool(dataKey, false);
                    }
                }
            }
        }
    }
}
