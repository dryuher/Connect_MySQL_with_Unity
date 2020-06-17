using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userInsert : MonoBehaviour {

    string URL = "http://localhost/MySQL_database/userInsert.php";
    public string InputUsername, InputEmail, InputPassword;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) {
            AddUser(InputUsername, InputEmail, InputPassword);
        }
		
	}

    public void AddUser(string username, string email, string password) {
        WWWForm form = new WWWForm();
        form.AddField("addUsername", username);
        form.AddField("addEmail", email);
        form.AddField("addPassword", password);

        WWW www = new WWW(URL, form);
    }
}
