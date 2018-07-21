 using System;
 using UnityEngine;
 using GoogleMobileAds;
 using GoogleMobileAds.Api;
 
 // Example script showing how to invoke the Google Mobile Ads Unity plugin.
 public class ad : MonoBehaviour
 {
 	private BannerView bannerView;
     
 
     void Start()
     {
         DontDestroyOnLoad(this);
         RequestBanner();
         
         
 
     }
     private void RequestBanner()
{
    
        string adUnitId = "ca-app-pub-2054147490410547/6427154513";
    

    // Create a 320x50 banner at the top of the screen.
    BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
    // Create an empty ad request.
    AdRequest request = new AdRequest.Builder().Build();
    // Load the banner with the request.
    bannerView.LoadAd(request);
    bannerView.Show();
}
 }