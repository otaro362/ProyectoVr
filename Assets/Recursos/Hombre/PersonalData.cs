using UnityEngine;
using UnityEngine.UI;
public class PersonalData : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_InputField firstNameInputF;
    [SerializeField] private TMPro.TMP_InputField lastNameInputF;
    [SerializeField] private TMPro.TMP_InputField ageInputF;
    [SerializeField] private TMPro.TMP_InputField identificationInputF;
    [SerializeField] private TMPro.TMP_Dropdown genderDropdown;
    [SerializeField] private TMPro.TMP_Dropdown escolarityDropdown;
    [SerializeField] private GameObject levelSelect;
    [SerializeField] private GameObject errorMessage;


    private void Awake()
    {
        levelSelect.SetActive(false);
        errorMessage.SetActive(false);
    }
    void Start()
    {
        SetGender();
        /* PlayerPrefs.DeleteKey("firstName");
        PlayerPrefs.DeleteKey("lastName");
        PlayerPrefs.DeleteKey("age");
        PlayerPrefs.DeleteKey("identification");
        PlayerPrefs.DeleteKey("gender");
        PlayerPrefs.DeleteKey("escolarity");
        */
    }

    public void SaveAll()
    {
        SetFirstName();
        SetLastName();
        SetAge();
        SetIdentification();
        SetGender();
        SetEscolarity();

        if (!string.IsNullOrEmpty(firstNameInputF.text) && !string.IsNullOrEmpty(lastNameInputF.text) && !string.IsNullOrEmpty(identificationInputF.text)
            && !string.IsNullOrEmpty(ageInputF.text))
        {
            gameObject.SetActive(false);
            levelSelect.SetActive(true);
        }
        else
            errorMessage.SetActive(true);
    }

    private void SetFirstName()
    {
        PlayerPrefs.SetString("firstName", firstNameInputF.text);
    }

    private void SetLastName()
    {
        PlayerPrefs.SetString("lastName", lastNameInputF.text);      
    }
    private void SetAge()
    {
        int age;
        if (string.IsNullOrEmpty(ageInputF.text))
            return;

        age = int.Parse(ageInputF.text);
        PlayerPrefs.SetInt("age", age);
    }
    private void SetIdentification()
    {
        int identification;
        if (string.IsNullOrEmpty(identificationInputF.text))
            return;
        
       if(int.TryParse(identificationInputF.text, out identification))
       PlayerPrefs.SetInt("identification", identification);
    }
    private void SetGender()
    {
        PlayerPrefs.SetString("gender", genderDropdown.options[genderDropdown.value].text);
    }
    private void SetEscolarity()
    {
        PlayerPrefs.SetString("escolarity", escolarityDropdown.options[escolarityDropdown.value].text);
    }
}
