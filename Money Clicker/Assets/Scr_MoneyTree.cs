using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scr_MoneyTree : MonoBehaviour {

	public Text Text_FundAmount;
	Scr_FundsManager BankAccountManager;

	public int NumOfTrees = 0;

	float Revenue;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("OneSecond", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OneSecond () { //Every second do this stuff

		BankAccountManager = Text_FundAmount.GetComponent<Scr_FundsManager> ();

		Revenue = NumOfTrees;

		BankAccountManager.IncreaseFunds(Revenue);
	}

	public void IncrementNumOfTress() {
		NumOfTrees ++;
	}
}
