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
    public void LoadPlasticBottleOrganizer()
    {
        SceneManager.LoadScene("EPlasticPage4PlasticBottleOrganizer");
    }
    public void LoadPlasticMiniature()
    {
        SceneManager.LoadScene("EPlasticPage5Miniature");
    }
    public void LoadPlasticFlowerVase()
    {
        SceneManager.LoadScene("EPlasticPage6PlasticFlowerVase");
    }
    public void LoadPlasticMirrorWithPlasticSpoon()
    {
        SceneManager.LoadScene("EPlasticPage7MirrorWithPlasticSpoon");
    }
    public void LoadPlasticArtificialFlower()
    {
        SceneManager.LoadScene("EPlasticPage8ArtificialFlower");
    }
    public void LoadPlasticHangingMoon()
    {
        SceneManager.LoadScene("EPlasticPage9HangingMoon");
    }
    public void LoadPlasticDIYFlower()
    {
        SceneManager.LoadScene("EPlasticPage10DIYFlower");
    }
    //EPlasticPage10DIYFlower

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
    public void LoadCandleLighting()
    {
        SceneManager.LoadScene("ECansPage5CandleLighting");
    }
    public void LoadCansTriangular()
    {
        SceneManager.LoadScene("ECansPage6Triangular");
    }
    public void LoadCanOrganizer()
    {
        SceneManager.LoadScene("ECansPage7CanOrganizer");
    }
    public void LoadCanTiered()
    {
        SceneManager.LoadScene("ECansPage8Tiered");
    }
    public void LoadCanDenimCan()
    {
        SceneManager.LoadScene("ECansPage9DenimCan");
    }
    public void LoadCanBottleCap()
    {
        SceneManager.LoadScene("ECansPage10BottleCap");
    }
    //ECansPage10BottleCap


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
    public void LoadPaperBowl()
    {
        SceneManager.LoadScene("EPaperPage4PaperBowl");
    }
    public void LoadPaperFlowerArt()
    {
        SceneManager.LoadScene("EPaperPage5FlowerArt");
    }
    public void LoadPaperHolder()
    {
        SceneManager.LoadScene("EPaperPage6PencilHolder");
    }
    public void LoadPaperMagazineFlower()
    {
        SceneManager.LoadScene("EPaperPage7MagazineFlower");
    }
    public void LoadPaperOrigamiFlower()
    {
        SceneManager.LoadScene("EPaperPage8OrigamiFlower");
    }
    public void LoadPaperCircularFlowerVase()
    {
        SceneManager.LoadScene("EPaperPage9CircularFlowerVase");
    }
    public void LoadPaperWallFlowerArt()
    {
        SceneManager.LoadScene("EPaperPage10WallFlowerArt");
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
    public void LoadGlassWineGlass()
    {
        SceneManager.LoadScene("EGlassPage4WineGlassVase");
    }
    public void LoadGlassLighting()
    {
        SceneManager.LoadScene("EGlassPage5GlassLighting");
    }
    public void LoadGlassPaperStick()
    {
        SceneManager.LoadScene("EGlassPage6PaperStickMasonJar");
    }
    public void LoadGlassSpoonAndMasonJar()
    {
        SceneManager.LoadScene("EGlassPage7SpoonAndMasonJar");
    }
    public void LoadGlassFloweVase()
    {
        SceneManager.LoadScene("EGlassPage8FlowerVase");
    }
    public void LoadGlassIlluminatedGlassBottle()
    {
        SceneManager.LoadScene("EGlassPage9IlluminatedGlassBottle");
    }
    public void LoadGlassPaintedMirror()
    {
        SceneManager.LoadScene("EGlassPage10PaintedMIrror");
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
    public void LoadTextileDenimFlower()
    {
        SceneManager.LoadScene("ETextilePage4DenimFlower");
    }
    public void LoadTextileApron()
    {
        SceneManager.LoadScene("ETextilePage5Apron");
    }
    public void LoadTextileWoven()
    {
        SceneManager.LoadScene("ETextilePage6Woven");
    }
    public void LoadTextilePencilOrganizer()
    {
        SceneManager.LoadScene("ETextilePage7PencilOrganizer");
    }
    public void LoadTextileToteBag()
    {
        SceneManager.LoadScene("ETextilePage8ToteBag");
    }
    public void LoadTextileUpcycleDenim()
    {
        SceneManager.LoadScene("ETextilePage9UpcycleDenim");
    }
    public void LoadTextileDenimWallOrganizer()
    {
        SceneManager.LoadScene("ETextilePage10DenimWallOrganizer");
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
    public void LoadCardboardVase()
    {
        SceneManager.LoadScene("ECBPage4CardboardVase");
    }
    public void LoadCardboardHangingLamp()
    {
        SceneManager.LoadScene("ECBPage5HangingLamp");
    }
    public void LoadCardboardPictureFrame()
    {
        SceneManager.LoadScene("ECBPage6PictureFrame");
    }
    public void LoadCardboardMiniCabinet()
    {
        SceneManager.LoadScene("ECBPage7MiniCabinet");
    }
    public void LoadCardboardJewerlyOrganizer()
    {
        SceneManager.LoadScene("ECBPage8JewelryOrganizer");
    }
    public void LoadCardboardBookHolder()
    {
        SceneManager.LoadScene("ECBPage9BookHolder");
    }
    public void LoadCardboardMakeUpOrganizer()
    {
        SceneManager.LoadScene("ECBPage10MakeUpOrganizer");
    }
  
}