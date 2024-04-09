using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace charactercontroller
{
    public class Menu : MonoBehaviour
    {
        public GameObject menuPannel;
        public GameObject pauseButton;
        public GameObject exitButton;
        public GameObject claire;
        public GameObject thumbStickLeft;

        //tick icon
        public GameObject tickPointAndClick;
        public GameObject tickThirdPerson;
        public GameObject tickThumbStickLeft;


        public void ActivateMenu()
        {
            menuPannel.SetActive(true);
            pauseButton.SetActive(false);
            exitButton.SetActive(true);
            claire.SetActive(false);

        }

        public void DeactivateMenu()
        {
            menuPannel.SetActive(false);
            pauseButton.SetActive(true);
            exitButton.SetActive(false);
            claire.SetActive(true);
        }

        public void ActivatePointAndClick()
        {
            claire.GetComponent<PontAndClick>().enabled = true;
            tickPointAndClick.SetActive(true);
            DeactivateThumbStickLeft();
        }
        public void ActivateThirdPerson()
        {
            claire.GetComponent<thirdPersonController>().enabled = true;
            tickThirdPerson.SetActive(true);
        }
        public void ActivateThumbStickLeft()
        {
            claire.GetComponent<ThumbStickContoller>().enabled = true;
            thumbStickLeft.SetActive(true);
            tickThumbStickLeft.SetActive(true);
            DeactivatePointAndClick();
        }

        public void DeactivatePointAndClick()
        {
            claire.GetComponent<PontAndClick>().enabled = false;
            tickPointAndClick.SetActive(false);
        }
        public void DeactivateThirdPerson()
        {
            claire.GetComponent<thirdPersonController>().enabled = false;
            tickThirdPerson.SetActive(false);
        }
        public void DeactivateThumbStickLeft()
        {
            claire.GetComponent<ThumbStickContoller>().enabled = false;
            thumbStickLeft.SetActive(false);
            tickThumbStickLeft.SetActive(false);
        }


    }
}
