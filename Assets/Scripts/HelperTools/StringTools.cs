using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Util functions and procedures to use with strings. */
public static class StringTools {

	/* Transforms a charArray to a string. */
	public static string charArrayToString(char[] arr){
		string str = "";
		for (int i = 0; i < arr.Length; i++)
			str += arr[i];
		return str;
	}
}
