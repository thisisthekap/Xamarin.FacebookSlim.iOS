# NukeProxy

This is a small Xamarin.iOS binding Proxy for [Nuke][nuke]. Since Nuke is a Swift library, which doesn't expose its code with `@objc` annotations, we cannot bind it directly and need a proxy for this.
This proxy provides enough API for [Xamarin.Forms.Nuke][xformsnuke] to function. If you need more of Nukes API to be surfaced, PRs are welcome.

## Installation

New! There is now a .net 6 version of the proxy targeting `ios` and `mac catalyst`.

### .Net 6 ios and macos

Nuget:

> Install-Package ImageCaching.Nuke

### Xamarin.Forms

NuGet:

> Install-Package Xamarin.

## Setting up locally

Make sure to install carthage first. This can be done through Homebrew:

```
brew install carthage
```


