using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scr_FundsManager : MonoBehaviour {

	public GameObject SourceOfFunds; //Requests increase or decrease of funds
	float DeltaFunds = 0; //The change of funds on this frame 
	float CurrentFunds = 0; //The current bank of funds

	public Text TextObject;


	// Use this for initialization
	void Start () {
		UpdateText ();
	}
	
	// Update is called once per frame
	void Update () {
		if (DeltaFunds != 0) { //If DeltaFunds has an amount, add it to CurrentFunds
			CurrentFunds += DeltaFunds;
			DeltaFunds = 0; //set DeltaFunds to 0 once it has been added
			UpdateText();
		}
	}

	public void IncreaseFunds(float Fundflow){ //Increse DeltaFunds by the amount of FundFlow
		DeltaFunds += Fundflow;
	}

	public void DecreaseFunds (float FundFlow){//Decrese DeltaFunds by the amount of FundFlow
		if (CurrentFunds >= FundFlow) {
			DeltaFunds -= FundFlow;
		}
	}

	void UpdateText(){ 					//Update Text to display current funds
		TextObject.text = CurrentFunds.ToString();
	}
}
