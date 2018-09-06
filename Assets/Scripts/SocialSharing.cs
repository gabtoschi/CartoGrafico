using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialSharing : MonoBehaviour {

    private string whatsAppString = "Eu acabei de viajar pelo Brasil com o CartoGráfico! Viaje você também!";

	private string whatsAppBaseURL = "https://wa.me/?text=";

    public void shareWhatsApp(){
		string wppURL = "";

		wppURL += whatsAppBaseURL;
		wppURL += whatsAppString;

		Application.OpenURL(wppURL);
	}
}
