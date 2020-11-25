using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{



    public static void SetHighScore(string nivel,int score)
    {
        if (score > PlayerPrefs.GetInt(nivel, 0))
        {
            PlayerPrefs.SetInt(nivel, score);
        }
    }

    public static void SetCoins(int score)
    {
        
        int coin= PlayerPrefs.GetInt("Coins", 0);
        PlayerPrefs.SetInt("Coins", coin+ score);
    }

    public static int GetCoins()
    {

        return PlayerPrefs.GetInt("Coins", 0);
    }


    public static void SetMejorDistancia(string nivel,int distancia)
    {

        int coin = PlayerPrefs.GetInt(nivel, 0);
        PlayerPrefs.SetInt(nivel,  distancia);
    }

    public static int GetMejorDistancia(string nivel)
    {

        return PlayerPrefs.GetInt(nivel, 0);
    }







    public static void SetUnlockNivel(string nombreNivel,bool bloqueado)
    {

        int boolInt = (bloqueado==true) ? 1 : -1;

        // 1== bloqueado
        //0== desbloqueado
        PlayerPrefs.SetInt(nombreNivel,boolInt);
    }

    public static int GetUnlockNivel(string nombreNivel)
    {

        return PlayerPrefs.GetInt(nombreNivel, 0);
    }


}

