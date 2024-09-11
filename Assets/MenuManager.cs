using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string sceneGame;
    [SerializeField] private GameObject viewLogin;
    [SerializeField] private GameObject viewUsers;
    [SerializeField] private GameObject viewRegister;
    [SerializeField] private Dropdown dropdownUsers;

    [SerializeField] private TextMeshProUGUI fieldId;
    [SerializeField] private TextMeshProUGUI fieldName;
    [SerializeField] private TextMeshProUGUI fieldBirthDate;
    [SerializeField] private TextMeshProUGUI fieldDays;
    [SerializeField] private TextMeshProUGUI fieldSex;
    [SerializeField] private Toggle fieldAuthorized;
    [SerializeField] private TextMeshProUGUI fieldCpf;
    [SerializeField] private TextMeshProUGUI fieldWeight;
    [SerializeField] private TextMeshProUGUI fieldNamePerson;
    [SerializeField] private TextMeshProUGUI fieldCity;

    public List<User> users = new List<User>();

    void Start(){

        viewLogin.SetActive(true);
        viewUsers.SetActive(false);
        viewRegister.SetActive(false);


        users.Add(new User(1, "Adriano", "01/01/1990", 5, "Masculino", true, 12345678901, 70.5f, "Responsável A", "Cidade A"));
        users.Add(new User(2, "Beatriz", "02/02/1992", 2, "Feminino", false, 23456789012, 60.0f, "Responsável B", "Cidade B"));

        FillDropdown();

        SelectUser(0);

        dropdownUsers.onValueChanged.AddListener(delegate { SelectUser(dropdownUsers.value); });
    }

    public void FillDropdown()
    {
        List<string> options = new List<string>();

        foreach (User user in users)
        {
            options.Add(user.name);
        }

        dropdownUsers.ClearOptions();
        dropdownUsers.AddOptions(options);

    }

    void SelectUser(int indice)
    {
        if (indice >= 0 && indice < users.Count)
        {
            User userSelect = users[indice];

            fieldId.text = userSelect.id;
            fieldName.text = userSelect.name;
            fieldBirthDate.text = userSelect.dateOfBirth;
            fieldDays.text = userSelect.days;
            fieldSex.text = userSelect.sex;
            fieldAuthorized.isOn = userSelect.authorized;
            fieldCpf.text = userSelect.cpf;
            fieldWeight.text = userSelect.weight;
            fieldNamePerson.text = userSelect.namePerson;
            fieldCity.text = userSelect.city;
            
        }
    }

    public void ViewUsers(){
        viewLogin.SetActive(false);
        viewUsers.SetActive(true);
        viewRegister.SetActive(false);
    }

    public void ViewRegister(){
        viewLogin.SetActive(false);
        viewUsers.SetActive(false);
        viewRegister.SetActive(true);
    }

    public void StartGame(){
        SceneManager.LoadScene(sceneGame);
    }

    public void HandleInputData(string value){
        Debug.Log(value);
    }

    

}
