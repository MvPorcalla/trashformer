using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnglishPageManager : MonoBehaviour
{
    // Page Manager script

    // Main Page
    public void LoadHomePage()
    {
        SceneManager.LoadScene("EHomePage");
    }
    

    // Move to Next Page ---------------------------------------------------------------------------------
    public void LoadFAQsPage()
    {
        SceneManager.LoadScene("FAQs");
    }
    public void LoadAboutPage()
    {
        SceneManager.LoadScene("about");
    }

    // Plastic ---------------------------------------------------------------------------------------------------------
    public void LoadPlasticPage()
    {
        SceneManager.LoadScene("EPlasticPage");
    }
    public void LoadPlasticBottleFlower()
    {
        SceneManager.LoadScene("EPlasticPage1PBF");
    }
    public void LoadPlasticDiscPainting()
    {
        SceneManager.LoadScene("EPlasticPage2DP");
    }
    public void LoadPlasticLampshade()
    {
        SceneManager.LoadScene("EPlasticPage3LPS");
    }


    // cans page ------------------------------------------------------------------------------------------
    public void LoadCansPage()
    {
        SceneManager.LoadScene("ECansPage");
    }
    public void LoadCansOrganizer()
    {
        SceneManager.LoadScene("ECansPage1Organizer");
    }
    public void LoadCansLantern()
    {
        SceneManager.LoadScene("ECansPage2Lantern");
    }
    public void LoadCansDreamCatcher()
    {
        SceneManager.LoadScene("ECansPage3DreamCatcher");
    }
    public void LoadCansLantern2()
    {
        SceneManager.LoadScene("ECansPage4CLT");
    }

    // Paper ---------------------------------------------------------------------------------------------------------
    public void LoadPaperPage()
    {
        SceneManager.LoadScene("EPaperPage");
    }
    public void LoadPaperWHFA()
    {
        SceneManager.LoadScene("EPaperPage1WHFA");
    }
    public void LoadPaperPaperBasket()
    {
        SceneManager.LoadScene("EPaperPage2PB");
    }
    public void LoadPaperWallHangingPaper()
    {
        SceneManager.LoadScene("EPaperPage3WH");
    }


    // Glass ----------------------------------------------------------------------------------------------------------
    public void LoadGlassPage()
    {
        SceneManager.LoadScene("EGlassPage");
    }
    public void LoadGlassLantern()
    {
        SceneManager.LoadScene("EGlassPage1GLT");
    }
    public void LoadGlassHangingjar()
    {
        SceneManager.LoadScene("EGlassPage2GKHJ");
    }
    public void LoadGlassPainting()
    {
        SceneManager.LoadScene("EGlassPage3GP");
    }

    // Textile ---------------------------------------------------------------------------------------------------------
    
    public void LoadTextilePage()
    {
        SceneManager.LoadScene("ETextilePage");
    }
    public void LoadTextileFabricPouch()
    {
        SceneManager.LoadScene("ETextilePage1RFP");
    }
    public void LoadTextileScrunchies()
    {
        SceneManager.LoadScene("ETextilePage2TS");
    } 
    public void LoadTextileEcoBag()
    {
        SceneManager.LoadScene("ETextilePage3OCE");
    }

    // cardboard page ------------------------------------------------------------------------------------------
    public void LoadCardboardPage()
    {
        SceneManager.LoadScene("ECardboardPage");
    }
    public void LoadCardboardHS()
    {
        SceneManager.LoadScene("ECBPage1CHS");
    }
    public void LoadCardboardHWS()
    {
        SceneManager.LoadScene("ECBPage2HWS");
    }
    public void LoadCardboardSO()
    {
        SceneManager.LoadScene("ECBPage3SO");
    }


}