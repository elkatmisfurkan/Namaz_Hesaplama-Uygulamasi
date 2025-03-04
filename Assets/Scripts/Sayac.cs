using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sayac : MonoBehaviour
{
    

    // Arttir Butonlari //
    public Button SabahNamaziArttirButonu;
    public Button OgleNamaziArttirButonu;
    public Button IkindiNamaziArttirButonu;
    public Button aksamNamaziArttirButonu;
    public Button YatsiNamaziArttirButonu;

    // Azalt Butonlari //
    public Button SabahNamaziEksiltButonu;
    public Button OgleNamaziEksiltButonu;
    public Button IkindiNamaziEksiltButonu;
    public Button AksamNamaziEksiltButonu;
    public Button YatsýNamaziEksiltButonu;

    // Sayac Textleri //
    public Text SabahNamaziText;
    public Text OgleNamaziText;
    public Text IkindiNamaziText;
    public Text AksamNamaziText;
    public Text YatsiNamaziText;

    // Sayaclar

    public int SabahNamaziSayisi;
    public int OgleNamaziSayisi;
    public int IkindiNamaziSayisi;
    public int AksamNamaziSayisi;
    public int YatsiNamaziSayisi;


    public void Start()
    {
        SabahNamaziSayisi = PlayerPrefs.GetInt("SabahNamazi");
        OgleNamaziSayisi = PlayerPrefs.GetInt("OgleNamazi");
        IkindiNamaziSayisi = PlayerPrefs.GetInt("ÝkindiNamazi");
        AksamNamaziSayisi = PlayerPrefs.GetInt("AksamNamazi");
        YatsiNamaziSayisi = PlayerPrefs.GetInt("YatsiNamazi");

        SabahNamaziText.text = SabahNamaziSayisi.ToString();
        OgleNamaziText.text = OgleNamaziSayisi.ToString();
        IkindiNamaziText.text = IkindiNamaziSayisi.ToString();
        AksamNamaziText.text = AksamNamaziSayisi.ToString();
        YatsiNamaziText.text = YatsiNamaziSayisi.ToString();





    }



    void Update()
    {

    }
    // Arttirma Fonksiyonlari
    public void SabahNamaziArttir()
    {
        SabahNamaziSayisi++;
        SabahNamaziText.text = SabahNamaziSayisi.ToString();
        PlayerPrefs.SetInt("SabahNamazi", SabahNamaziSayisi);

    }
    public void OgleNamaziArttir()
    {
        OgleNamaziSayisi++;
        OgleNamaziText.text = OgleNamaziSayisi.ToString();
        PlayerPrefs.SetInt("OgleNamazi", OgleNamaziSayisi);

    }
    public void IkindiNamaziArttir()
    {
        IkindiNamaziSayisi++;
        IkindiNamaziText.text = IkindiNamaziSayisi.ToString();
        PlayerPrefs.SetInt("ÝkindiNamazi", IkindiNamaziSayisi);

    }
    public void AksamNamaziArttir()
    {
        AksamNamaziSayisi++;
        AksamNamaziText.text = AksamNamaziSayisi.ToString();
        PlayerPrefs.SetInt("AksamNamazi", AksamNamaziSayisi);

    }
    public void YatsiNamaziArttir()
    {
        YatsiNamaziSayisi++;
        YatsiNamaziText.text = YatsiNamaziSayisi.ToString();
        PlayerPrefs.SetInt("YatsiNamazi", YatsiNamaziSayisi);

    }
    // AzaltmaFonksiyonlari
    public void SabahNamaziAzalt()
    {
        SabahNamaziSayisi--;
        SabahNamaziText.text = SabahNamaziSayisi.ToString();

        if (SabahNamaziSayisi <= 0)
        {
            SabahNamaziSayisi = 0;
            SabahNamaziText.text = "0";
        }
        PlayerPrefs.SetInt("SabahNamazi", SabahNamaziSayisi);

    }
    public void OgleNamaziAzalt()
    {
        OgleNamaziSayisi--;
        OgleNamaziText.text = OgleNamaziSayisi.ToString();

        if (OgleNamaziSayisi <= 0)
        {
            OgleNamaziSayisi = 0;
            OgleNamaziText.text = "0";

        }
        PlayerPrefs.SetInt("OgleNamazi", OgleNamaziSayisi);


    }
    public void IkindiNamaziAzalt()
    {
        IkindiNamaziSayisi--;
        IkindiNamaziText.text = IkindiNamaziSayisi.ToString();

        if (IkindiNamaziSayisi <= 0)
        {
            IkindiNamaziSayisi = 0;
            IkindiNamaziText.text = "0";
        }
        PlayerPrefs.SetInt("ÝkindiNamazi", IkindiNamaziSayisi);


    }
    public void AksamNamaziAzalt()
    {
        AksamNamaziSayisi--;
        AksamNamaziText.text = AksamNamaziSayisi.ToString();

        if (AksamNamaziSayisi <= 0)
        {
            AksamNamaziSayisi = 0;
            AksamNamaziText.text = "0";

        }
        PlayerPrefs.SetInt("AksamNamazi", AksamNamaziSayisi);



    }
    public void YatsiNamaziAzalt()
    {
        YatsiNamaziSayisi--;
        YatsiNamaziText.text = YatsiNamaziSayisi.ToString();

        if (YatsiNamaziSayisi <= 0)
        {
            YatsiNamaziSayisi = 0;
            YatsiNamaziText.text = "0";

        }
        PlayerPrefs.SetInt("YatsiNamazi", YatsiNamaziSayisi);


    }

    public void Sifirla()
    {
        PlayerPrefs.DeleteAll();
        YatsiNamaziText.text = "0";
        AksamNamaziText.text = "0";
        IkindiNamaziText.text = "0";
        OgleNamaziText.text = "0";
        SabahNamaziText.text = "0";


    }

}
