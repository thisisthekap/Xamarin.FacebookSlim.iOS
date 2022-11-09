//

import Foundation
import UIKit
import FacebookLogin

@objc(LoginButtonFb)
public class LoginButtonFb : NSObject {
    
    @objc
    public static let shared = LoginButtonFb()
    
    
    
    @objc
    public func loadData(view: UIView) -> UIView {
        
        let loginButton = FBLoginButton()
        loginButton.permissions = ["public_profile", "email"]
        loginButton.center = view.center
        return loginButton
    }
}
