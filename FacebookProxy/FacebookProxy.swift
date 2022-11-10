//

import Foundation
import UIKit
import FacebookLogin

public enum loginResultEnum {
    case Erorr
    case Cancelled
    case LoggedIn
}

@objc(LoginProxyManager)
public class LoginProxyManager : NSObject {
    
    @objc
    public static let shared = LoginProxyManager()
    public let loginManager = LoginManager()
    
    
    
    @objc
    public func loadData(view: UIView) -> UIView {
        
        let loginButton = FBLoginButton()
        loginButton.permissions = ["public_profile", "email"]
        loginButton.center = view.center
        return loginButton
    }
    
    public func login(viewController: UIViewController, onCompleted: @escaping  (loginResultEnum?) -> Void) {
        
        LoginProxyManager.shared.loginManager.logIn(permissions: ["public_profile", "email"], from: viewController) { result, error in
                    if let error = error {
                        print("Encountered Erorr: \(error)")
                        onCompleted(loginResultEnum.Erorr)
                    } else if let result = result, result.isCancelled {
                        print("Cancelled")
                        onCompleted(loginResultEnum.Cancelled)
                    } else {
                        onCompleted(loginResultEnum.LoggedIn)
                        print("Logged In")
                    }
                }
    }
    
    @objc
    public func logout() -> Void {
        LoginProxyManager.shared.loginManager.logOut();
    }
}
