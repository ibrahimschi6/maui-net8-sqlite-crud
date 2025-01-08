# Developing a .NET MAUI App on MacBook Using Visual Studio Code

This guide explains how to set up and develop a .NET MAUI (Multi-platform App UI) app on a MacBook Pro using Visual Studio Code.

---

## 1. Install Prerequisites

### a. Install .NET SDK
- Download and install the latest .NET SDK (7.0 or later) from the [.NET download page](https://dotnet.microsoft.com/download).
  ```bash
  dotnet --version
  ```
  Verify the installation by checking the installed version.

### b. Install Xcode
- Install Xcode from the Mac App Store.
- Open Xcode, accept the license, and install the necessary components.
  ```bash
  xcode-select --install
  ```

### c. Set Up Android SDK
- Install Android Studio from the [Android developer site](https://developer.android.com/studio).
- Launch Android Studio and install:
  - Android SDK
  - Android Emulator
  - Required SDK tools (e.g., SDK Build Tools, Platform Tools)

### d. Install Visual Studio Code
- Download and install **Visual Studio Code** from the [official website](https://code.visualstudio.com/).

### e. Install .NET MAUI Workload
- Install the .NET MAUI workload for your .NET SDK:
  ```bash
  dotnet workload install maui
  ```

### f. Install Additional Extensions
- Open Visual Studio Code and install the following extensions:
  - **C#**: Provides IntelliSense and debugging for .NET.
  - **XAML Support** (optional): Enhances editing XAML files.

---

## 2. Create a New .NET MAUI Project

1. Open a terminal in Visual Studio Code or your system terminal.
2. Use the following command to create a new MAUI project:
   ```bash
   dotnet new maui -n MyMauiApp
   ```
3. Navigate to the project folder:
   ```bash
   cd MyMauiApp
   ```

---

## 3. Configure the Environment

### a. iOS Development
- Connect an iPhone or use an iOS Simulator (set up via Xcode).
- Ensure your Apple Developer account is configured in Xcode.

### b. Android Development
- Launch the Android emulator or connect a physical Android device.
- Ensure the device is detected:
  ```bash
  adb devices
  ```

---

## 4. Run and Debug the App

### a. Run on iOS
- Use the following command to run the app on an iOS simulator:
  ```bash
  dotnet build -t:Run -f net7.0-ios
  ```

- Use the following command to see available iOS devices or simulators:
  ```bash
  xcrun simctl list
  ```


- Use the following command to run the app on a specific iOS device:
  ```bash
  dotnet build -t:Run -f net8.0-ios /p:_DeviceName=:v2:udid=<DEVICE ID>
  ```

### b. Run on Android
- Use this command to run the app on an Android device/emulator:
  ```bash
  dotnet build -t:Run -f net7.0-android
  ```

### c. Run on macOS
- To run the app on macOS:
  ```bash
  dotnet build -t:Run -f net7.0-macos
  ```

---

## 5. Edit and Develop the App

- Open the project in Visual Studio Code:
  ```bash
  code .
  ```
- Navigate to `MainPage.xaml` and `MainPage.xaml.cs` to edit the UI and logic.
- Use the **C#** extension for IntelliSense and debugging.

---

## 6. Debugging in Visual Studio Code

- Open the **Run and Debug** tab in Visual Studio Code.
- Add a new **launch configuration** for .NET MAUI if prompted.
- Set breakpoints and use the integrated debugger.

---

## 7. Build and Publish

### a. For iOS
- Archive the app for publishing using the `dotnet` CLI:
  ```bash
  dotnet publish -f net7.0-ios -c Release /p:ArchiveOnBuild=true
  ```
- Use Xcode to sign and upload the app to the App Store.

### b. For Android
- Create a signed APK/AAB:
  ```bash
  dotnet publish -f net7.0-android -c Release
  ```

### c. For macOS
- Package the app for distribution:
  ```bash
  dotnet publish -f net7.0-macos -c Release
  ```

---

## 8. Testing the App

- Use physical devices and emulators for testing on various platforms.
- For Android, use `adb` to debug and test.
- For iOS, use Xcode's simulator or a connected device.

---

This guide ensures you can set up and develop .NET MAUI apps efficiently on a MacBook using Visual Studio Code.
