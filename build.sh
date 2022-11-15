#!/bin/bash

sh carthage.sh update --use-xcframeworks 

xcodebuild archive -sdk iphoneos -project ios/FacebookProxy.xcodeproj -scheme FacebookProxy -configuration Release -archivePath Output/Output-iphoneos SKIP_INSTALL=NO
xcodebuild archive -sdk iphonesimulator -project ios/FacebookProxy.xcodeproj -scheme FacebookProxy -configuration Release -archivePath Output/Output-iphonesimulator SKIP_INSTALL=NO

xcodebuild -create-xcframework -framework Output/Output-iphonesimulator.xcarchive/Products/Library/Frameworks/FacebookProxy.framework -framework Output/Output-iphoneos.xcarchive/Products/Library/Frameworks/FacebookProxy.framework -output Output/FacebookProxy.xcframework
