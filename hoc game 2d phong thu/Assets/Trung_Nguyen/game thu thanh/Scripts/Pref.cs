using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Pref 
{
    public static int BestScore
    {
        set
        {
            int oldBestScore = PlayerPrefs.GetInt(Const.BEST_SCORE_PREF, 0);
            if (oldBestScore < value)
                PlayerPrefs.SetInt(Const.BEST_SCORE_PREF, value);
        }

        get => PlayerPrefs.GetInt(Const.BEST_SCORE_PREF, 0);
    }

    public static int curPlayerId
    {
        set
        {
            PlayerPrefs.SetInt (Const.CUR_PLAYER_ID_PREF, value);   
        }

        get
        {
            return PlayerPrefs.GetInt (Const.CUR_PLAYER_ID_PREF, 0);
        }
    }

    public static int Coins
    {
        set
        {
            PlayerPrefs.SetInt (Const.COIN_PREF, value);
        }

        get
        {
            return PlayerPrefs.GetInt (Const.COIN_PREF, 0);
        }
    }

    public static float musicVol
    {
        set
        {
            PlayerPrefs.SetFloat(Const.MUSIC_VOL_PREF, value);  
        }

        get
        {
            return PlayerPrefs.GetFloat (Const.MUSIC_VOL_PREF, 0); 
        }
    }

    public static float musicSound
    {
        set
        {
            PlayerPrefs.SetFloat(Const.SOUND_VOL_PREF, value);
        }

        get
        {
            return PlayerPrefs.GetFloat(Const.SOUND_VOL_PREF, 0);
        }
    }

    public static void SetBool (string key, bool value)
    {
        if (value)
        {
            PlayerPrefs.SetInt (key, 1);
        }
        else PlayerPrefs.SetInt (key, 0);
    }

    public static bool GetBool (string key)
    {
        int check = PlayerPrefs.GetInt (key);
        if (check == 0) 
            return false;
        else return true;

        return false;
    }
}
