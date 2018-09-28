using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialSharing : MonoBehaviour {

    private string message = "Eu acabei de viajar pelo Brasil com o CartoGráfico! Viaje você também!\nLink para Google Play:https://play.google.com/store/apps/details?id=com.cjccbasp.CartoGrafico";

	private string whatsAppBaseURL = "https://wa.me/?text=";
	private string twitterBaseURL = "https://twitter.com/intent/tweet?text=";

    public void shareWhatsApp(){
		string wppURL = "";

		wppURL += whatsAppBaseURL;
		wppURL += message;

		Application.OpenURL(wppURL);
	}

	public void shareTwitter(){
		string tweet = "";

		tweet += twitterBaseURL;
		tweet += message;

		Application.OpenURL(tweet);
	}
}
