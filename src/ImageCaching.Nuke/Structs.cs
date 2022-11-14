using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace FacebookProxy
{
    [Native]
    public enum AppEventNameEnum : long
    {
        AchievedLevel = 0,
        AddedPaymentInfo = 1,
        AddedToCart = 2,
        AddedToWishlist = 3,
        CompletedRegistration = 4,
        CompletedTutorial = 5,
        InitiatedCheckout = 6,
        Purchased = 7,
        Rated = 8,
        Searched = 9,
        SpentCredits = 10,
        UnlockedAchievement = 11,
        ViewedContent = 12,
        Contact = 13,
        CustomizeProduct = 14,
        Donate = 15,
        FindLocation = 16,
        Schedule = 17,
        StartTrial = 18,
        SubmitApplication = 19,
        Subscribe = 20,
        AdImpression = 21,
        AdClick = 22
    }

    [Native]
    public enum ProxyLoggingBehavior : long
    {
        AccessTokens = 0,
        PerformanceCharacteristics = 1,
        AppEvents = 2,
        Informational = 3,
        CacheErrors = 4,
        UIControlErrors = 5,
        GraphAPIDebugWarning = 6,
        GraphAPIDebugInfo = 7,
        NetworkRequests = 8,
        DeveloperErrors = 9
    }

    [Native]
    public enum loginResultEnum : long
    {
        Erorr = 0,
        Cancelled = 1,
        LoggedIn = 2
    }
}

