using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI trashLeftTxt;

    [SerializeField]
    private TextMeshProUGUI energyLeftTxt;

    private int trashLeft;

    private CollectablesManager collectablesManager;

    public void SetTotalTrash(CollectablesManager collectablesManager)
    {
        this.collectablesManager = collectablesManager;

        trashLeft = collectablesManager.numberOfCollectables;

        trashLeftTxt.text = trashLeft.ToString();
    }

    public void UpdateTotalTrash()
    {
        trashLeft--;

        trashLeftTxt.text = trashLeft.ToString();
    }
}