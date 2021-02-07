using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CardDisplay : MonoBehaviour {

	public Card card;

	public Text nameText;
	public Text descriptionText;

	public Image artworkImage;

	public TextMeshProUGUI cost;

	public GameObject transPrefab;
	public bool cardBack;
	public CardSystemManager CardSystemManager;

	// Use this for initialization
	void Start () {
		nameText.text = card.name;
		descriptionText.text = card.description;
		artworkImage.sprite = card.artwork;
		cost.text = card.attack.ToString();
		transPrefab = card.TransPrefab;
		cardBack = false;
	}
	public void qteTest()
    {
		CardSystemManager.BattleController.QTETracker.StartCoroutine("InstantiateCircle", transPrefab.GetComponent<CircleTrans>());

	}
}
