using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RegisterUser : MonoBehaviour
{
    [SerializeField] private TMP_InputField fieldId;
    [SerializeField] private TMP_InputField fieldName;
    [SerializeField] private TMP_InputField fieldBirthDate;
    [SerializeField] private TMP_InputField fieldDays;
    [SerializeField] private TMP_InputField fieldSex;
    [SerializeField] private Toggle fieldAuthorized;
    [SerializeField] private TMP_InputField fieldCpf;
    [SerializeField] private TMP_InputField fieldWeight;
    [SerializeField] private TMP_InputField fieldNamePerson;
    [SerializeField] private TMP_InputField fieldCity;

    public void RegisterUsers()
    {

        MenuManager menuManager = FindObjectOfType<MenuManager>();

        if (menuManager == null)
        {
            Debug.LogError("MenuManager não encontrado.");
            return;
        }
        
        int id = int.Parse(fieldId.text);
        int days = int.Parse(fieldDays.text);
        float weight = float.Parse(fieldWeight.text);
        long cpf = long.Parse(fieldCpf.text);

        User newUser = new User(
            id,
            fieldName.text,
            fieldBirthDate.text,
            days,
            fieldSex.text,
            fieldAuthorized.isOn,
            cpf,
            weight,
            fieldNamePerson.text,
            fieldCity.text
        );

        menuManager.users.Add(newUser);

        Debug.Log(menuManager.users);

        FindObjectOfType<MenuManager>().FillDropdown();
    }

}
