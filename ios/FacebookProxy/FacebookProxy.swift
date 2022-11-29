//

import Foundation
import UIKit
import FacebookLogin

@objc public enum LoginResultEnum : Int {
    case Error
    case Cancelled
    case LoggedIn
}

@objc public enum ProxyLoggingBehavior : Int {
    case   AccessTokens
    case   PerformanceCharacteristics
    case   AppEvents
    case   Informational
    case   CacheErrors
    case   UIControlErrors
    case   GraphAPIDebugWarning
    case   GraphAPIDebugInfo
    case   NetworkRequests
    case   DeveloperErrors
}

@objc public class LoginResult : NSObject {

    @objc public var token = ""
    @objc public var authenticationToken = ""
    @objc public var grantedPermissions: Set<String> = []
    @objc public var declinedPermissions: Set<String> = []
}

@objc public enum AppEventNameEnum : Int {
    case   AchievedLevel
    case   AddedPaymentInfo
    case   AddedToCart
    case   AddedToWishlist
    case   CompletedRegistration
    case   CompletedTutorial
    case   InitiatedCheckout
    case   Purchased
    case   Rated
    case   Searched
    case   SpentCredits
    case   UnlockedAchievement
    case   ViewedContent
    case   Contact
    case   CustomizeProduct
    case   Donate
    case   FindLocation
    case   Schedule
    case   StartTrial
    case   SubmitApplication
    case   Subscribe
    case   AdImpression
    case   AdClick
  }

@objc(LoginManagerSlim)
public class LoginManagerSlim : NSObject {
    
    @objc
    public static let shared = LoginManagerSlim()
    private let loginManager = LoginManager()
    
    @objc
    public func login(viewController: UIViewController, onCompleted: @escaping  (LoginResultEnum, LoginResult?) -> Void) {
        
        LoginManagerSlim.shared.loginManager.logIn(permissions: ["public_profile", "email"], from: viewController) { result, error in
            if let error = error {
                print("Encountered Erorr: \(error)")
                onCompleted(LoginResultEnum.Error, nil)
            } else if let result = result, result.isCancelled {
                print("Cancelled")
                onCompleted(LoginResultEnum.Cancelled, nil)
            } else {
                print("Logged In")
                let loginResult = LoginResult()
                
                loginResult.token = result?.token?.tokenString ?? ""
                loginResult.authenticationToken = result?.authenticationToken?.tokenString ?? ""
                loginResult.grantedPermissions = result?.grantedPermissions ?? []
                loginResult.declinedPermissions = result?.declinedPermissions ?? []
                
                onCompleted(LoginResultEnum.LoggedIn, loginResult)
            }
        }
    }
    
    @objc
    public func logout() -> Void {
        LoginManagerSlim.shared.loginManager.logOut();
    }
}


@objc(CoreKitManagerSlim)
public class CoreKitManagerSlim : NSObject {
    
    @objc
    public static let shared = CoreKitManagerSlim()
    private static let settings = FBSDKCoreKit.Settings()
    
    @objc
    public func enableLoggingBehavior(apploggingBehavior: ProxyLoggingBehavior) -> Void{
        
        var loggingBehavior = LoggingBehavior.appEvents
        
        switch apploggingBehavior {
        case   ProxyLoggingBehavior.AccessTokens:
                loggingBehavior = LoggingBehavior.accessTokens
        case   ProxyLoggingBehavior.PerformanceCharacteristics:
                loggingBehavior = LoggingBehavior.performanceCharacteristics
        case   ProxyLoggingBehavior.AppEvents:
                loggingBehavior = LoggingBehavior.appEvents
        case   ProxyLoggingBehavior.Informational:
                loggingBehavior = LoggingBehavior.informational
        case   ProxyLoggingBehavior.CacheErrors:
                loggingBehavior = LoggingBehavior.cacheErrors
        case   ProxyLoggingBehavior.UIControlErrors:
            loggingBehavior = LoggingBehavior.uiControlErrors
        case   ProxyLoggingBehavior.GraphAPIDebugWarning:
                loggingBehavior = LoggingBehavior.graphAPIDebugWarning
        case   ProxyLoggingBehavior.GraphAPIDebugInfo:
                loggingBehavior = LoggingBehavior.graphAPIDebugInfo
        case   ProxyLoggingBehavior.NetworkRequests:
                loggingBehavior = LoggingBehavior.networkRequests
        case   ProxyLoggingBehavior.DeveloperErrors:
                loggingBehavior = LoggingBehavior.developerErrors
        }
       
        CoreKitManagerSlim.settings.enableLoggingBehavior(loggingBehavior)
    }
    
    @objc
    public func IsAdvertiserTrackingEnabled(enabled : Bool) -> Void{
        CoreKitManagerSlim.settings.isAdvertiserTrackingEnabled = enabled
    }
    
    @objc
    public func isAdvertiserTrackingEnabled() -> Bool{
        return CoreKitManagerSlim.settings.isAdvertiserTrackingEnabled
    }
    
    @objc
    public func IsAdvertiserIdCollectionEnabled(enabled : Bool) -> Void{
        CoreKitManagerSlim.settings.isAdvertiserIDCollectionEnabled = enabled
    }
    
    @objc
    public func isAdvertiserIdCollectionEnabled() -> Bool{
        return CoreKitManagerSlim.settings.isAdvertiserIDCollectionEnabled
    }
    
    @objc
    public func logEvent(appEventName : AppEventNameEnum, appparameters : NSDictionary) -> Void{
        
        var appEventsName = AppEvents.Name("default")
        
        switch appEventName {
        case AppEventNameEnum.AchievedLevel:
            appEventsName = AppEvents.Name.achievedLevel
        case AppEventNameEnum.AddedPaymentInfo:
            appEventsName = AppEvents.Name.addedPaymentInfo
        case AppEventNameEnum.AddedToCart:
            appEventsName = AppEvents.Name.addedToCart
        case AppEventNameEnum.AddedToWishlist:
            appEventsName = AppEvents.Name.addedToWishlist
        case AppEventNameEnum.CompletedRegistration:
            appEventsName = AppEvents.Name.completedRegistration
        case AppEventNameEnum.CompletedTutorial:
            appEventsName = AppEvents.Name.completedTutorial
        case AppEventNameEnum.InitiatedCheckout:
            appEventsName = AppEvents.Name.initiatedCheckout
        case AppEventNameEnum.Purchased:
            appEventsName = AppEvents.Name.purchased
        case AppEventNameEnum.Rated:
            appEventsName = AppEvents.Name.rated
        case AppEventNameEnum.Searched:
            appEventsName = AppEvents.Name.searched
        case AppEventNameEnum.SpentCredits:
            appEventsName = AppEvents.Name.spentCredits
        case AppEventNameEnum.UnlockedAchievement:
            appEventsName = AppEvents.Name.unlockedAchievement
        case AppEventNameEnum.ViewedContent:
            appEventsName = AppEvents.Name.viewedContent
        case AppEventNameEnum.Contact:
            appEventsName = AppEvents.Name.contact
        case AppEventNameEnum.CustomizeProduct:
            appEventsName = AppEvents.Name.customizeProduct
        case AppEventNameEnum.Donate:
            appEventsName = AppEvents.Name.donate
        case AppEventNameEnum.FindLocation:
            appEventsName = AppEvents.Name.findLocation
        case AppEventNameEnum.Schedule:
            appEventsName = AppEvents.Name.schedule
        case AppEventNameEnum.StartTrial:
            appEventsName = AppEvents.Name.startTrial
        case AppEventNameEnum.SubmitApplication:
            appEventsName = AppEvents.Name.submitApplication
        case AppEventNameEnum.Subscribe:
            appEventsName = AppEvents.Name.subscribe
        case AppEventNameEnum.AdImpression:
            appEventsName = AppEvents.Name.adImpression
        case AppEventNameEnum.AdClick:
            appEventsName = AppEvents.Name.adClick
        }
        
        FBSDKCoreKit.AppEvents.shared.logEvent(appEventsName)
    }
    
    @objc
    public func logEventCustom(appEventName : NSString, appparameters : NSDictionary) -> Void{
        
        var appEventsName = AppEvents.Name(appEventName as String)
        FBSDKCoreKit.AppEvents.shared.logEvent(appEventsName)
    }
    
    
    @objc
    public func initializeSdk() -> Void{
        FBSDKCoreKit.ApplicationDelegate.shared.initializeSDK()
    }
    
}

