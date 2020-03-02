using UnityEngine;
using System.Collections;
#if UNITY_ADS
using UnityEngine.Advertisements;
#endif
using UnityEngine.Analytics;

 public class GameOverAds : MonoBehaviour {

	// Use this for initialization

    int qtdJogatinas;
	void Start () {


        //Gender gender = Gender.Female;
        //Analytics.SetUserGender(gender);

        //int birthYear = 2014;
        //Analytics.SetUserBirthYear(birthYear);


        qtdJogatinas = PlayerPrefs.GetInt("qtdJogatinas");
        qtdJogatinas++;
        PlayerPrefs.SetInt("qtdJogatinas", qtdJogatinas);
        if (qtdJogatinas % 5 == 0)
        {

            ShowAd();
        }
	}

    public void ShowAd()
    {
		#if UNITY_ADS
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
		#endif
    }

}
