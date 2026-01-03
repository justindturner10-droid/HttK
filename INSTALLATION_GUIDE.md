# Complete Installation Guide - TCG Creation Tool

This guide will walk you through installing everything you need from scratch. No prior experience required!

---

## 📋 What You'll Install

1. **Unity Hub** - Manages Unity installations and projects
2. **Unity 2022.3 LTS** - The game engine
3. **Visual Studio Community** - Code editor (comes with Unity)
4. **(Optional) Git** - If you don't have it already

**Total Download Size:** ~5-7 GB
**Total Time:** 30-60 minutes depending on internet speed

---

## Step 1: Install Unity Hub

Unity Hub is the launcher that manages different Unity versions and your projects.

### Download Unity Hub:

1. Go to: **https://unity.com/download**
2. Click the big blue **"Download Unity Hub"** button
3. The download should start automatically (UnityHubSetup.exe, ~150 MB)

### Install Unity Hub:

1. Find the downloaded file (usually in your Downloads folder)
2. Double-click **UnityHubSetup.exe**
3. Click **"Yes"** if Windows asks for permission
4. Follow the installer:
   - Click **"I Agree"** to accept the license
   - Choose install location (default is fine: `C:\Program Files\Unity Hub`)
   - Click **"Install"**
   - Wait for installation to complete (~1 minute)
   - Click **"Finish"**

### First-Time Setup:

1. Unity Hub will open automatically
2. You'll see a welcome screen
3. Click **"Skip installation"** for now (we'll do it properly next)
4. You may be asked to create a Unity account or sign in:
   - Click **"Create account"** if you don't have one
   - OR click **"Sign in"** if you do
   - Use Google/Facebook/Email to sign up (free)

**✅ Unity Hub is now installed!**

---

## Step 2: Get a Unity License (Free)

Unity requires a license, but the Personal license is completely free.

### Activate Personal License:

1. In Unity Hub, click the **⚙️ gear icon** (top right) → **License Management**
2. Click **"Add"** button
3. Select **"Get a free personal license"**
4. Click **"Agree and get personal edition license"**
5. You should see "Unity Personal" with a checkmark

**✅ License activated!**

---

## Step 3: Install Unity 2022.3 LTS

Now we'll install the actual Unity Editor.

### Install Unity Editor:

1. In Unity Hub, click the **"Installs"** tab (left sidebar)
2. Click the blue **"Install Editor"** button (top right)
3. You'll see a list of Unity versions
4. Find **"2022.3.XX LTS"** (XX is the latest patch number, e.g., 2022.3.50)
   - Look for the green **"LTS"** (Long Term Support) badge
   - If you don't see it, click **"Archive"** and find 2022.3 LTS there

5. Click **"Install"** next to 2022.3 LTS

### Choose Modules (Important!):

You'll see a screen asking which modules to install. Check these boxes:

**Required:**
- ✅ **Microsoft Visual Studio Community** (code editor)
- ✅ **Windows Build Support (IL2CPP)** (for building your game)

**Optional but Recommended:**
- ✅ **Documentation** (offline help docs)
- ✅ **Language Pack - [Your Language]** (if not English)

**NOT Needed (save space):**
- ❌ Android Build Support
- ❌ iOS Build Support
- ❌ Mac Build Support
- ❌ WebGL Build Support
- ❌ Linux Build Support

6. Click **"Continue"**
7. Accept the license agreements (check both boxes)
8. Click **"Continue"**

### Wait for Download & Install:

- Download size: ~4-6 GB depending on selected modules
- Time: 20-45 minutes depending on internet speed
- You can minimize Unity Hub and do other things while it downloads
- **Don't close Unity Hub!**

**Progress will show:**
- Downloading...
- Installing...
- When complete, you'll see "2022.3.XX LTS" in your Installs list with a green dot

**✅ Unity 2022.3 LTS is now installed!**

---

## Step 4: Set Up Your Project

Now we'll create the Unity project in your existing repository.

### Create New Unity Project:

1. In Unity Hub, click the **"Projects"** tab (left sidebar)
2. Click the blue **"New Project"** button (top right)
3. At the top, make sure **"2022.3.XX"** is selected as the Editor Version
4. Choose a template:
   - Select **"2D Core"** template
   - (It's the simplest 2D template, perfect for a card game)

5. Configure your project:
   - **Project Name:** `TCG-Creator` (or whatever you prefer)
   - **Location:** Click **"..."** button and navigate to:
     - Find your `HttK` folder (wherever you cloned the repository)
     - **IMPORTANT:** Select the `HttK` folder itself, NOT a subfolder
   - **Organization:** Leave as default or set to your name

6. Click **"Create Project"**

### First-Time Unity Loading:

- Unity will open for the first time
- This takes 2-5 minutes (importing default assets)
- You'll see the Unity Editor interface
- Don't worry if it looks complicated - we'll guide you!

**✅ Unity project created!**

---

## Step 5: Verify Your Setup

Let's make sure everything is working correctly.

### Check Unity Editor:

You should see the Unity Editor with several windows:
- **Scene** (center) - 3D/2D viewport
- **Game** (center, tab next to Scene) - Game preview
- **Hierarchy** (left) - Objects in scene
- **Project** (bottom) - Your files and folders
- **Inspector** (right) - Properties panel
- **Console** (bottom, tab) - Error messages and logs

### Verify Project Structure:

1. In the **Project** window (bottom), you should see an **"Assets"** folder
2. Click the **► arrow** next to "Assets" to expand it
3. You should see the folders we created:
   - ✅ Scripts
   - ✅ Resources
   - ✅ Scenes
   - ✅ Prefabs
   - ✅ Art
   - ✅ Audio

### Check Scripts Compile:

1. Look at the bottom of the Unity window
2. You should see a progress bar that says "Compiling scripts..."
3. Wait for it to finish (30 seconds to 2 minutes)
4. Open the **Console** window (bottom tabs, click "Console")
5. **If you see ERRORS (red icons):**
   - This is normal! The scripts need Unity-specific files
   - Don't worry, we'll fix this in the next step

**✅ Unity Editor is working!**

---

## Step 6: Configure Visual Studio

Visual Studio Community was installed with Unity. Let's set it up.

### Set Visual Studio as Default Editor:

1. In Unity, go to menu: **Edit → Preferences**
2. In the left sidebar, click **"External Tools"**
3. Under "External Script Editor", select **"Microsoft Visual Studio Community 2022"**
   - If it says "Browse...", click it and navigate to:
     - `C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe`
4. Close the Preferences window

### Test Opening a Script:

1. In the Project window, navigate to: **Assets → Scripts → Data → CardDefinitions**
2. Double-click **CardFieldDefinition.cs**
3. Visual Studio should open (first time takes 30-60 seconds)
4. You'll see the C# code we created!

**✅ Visual Studio is configured!**

---

## Step 7: Fix Unity Project Settings

Unity projects need some specific files. Let's create them.

### Create Essential Unity Files:

We need to create a few Unity-specific configuration files so the project works properly.

1. Close Unity if it's open (File → Exit)
2. We'll create the required Unity files in the next step

**Don't worry - I'll help you create these files!**

---

## 🎉 Installation Complete!

You now have:
- ✅ Unity Hub installed and configured
- ✅ Unity 2022.3 LTS installed
- ✅ Visual Studio Community installed
- ✅ Unity project created in your repository
- ✅ Visual Studio configured as code editor

---

## Next Steps

1. **Create Unity project files** (I'll help you with this)
2. **Set up the scene structure**
3. **Create your first ScriptableObject**
4. **Test the system**

---

## System Requirements Check

Make sure your PC meets these requirements:

**Minimum:**
- Windows 10 (64-bit)
- Intel Core i3 or equivalent
- 8 GB RAM
- 10 GB free disk space
- Graphics: Any card with DX10 support

**Recommended:**
- Windows 11
- Intel Core i5 or better
- 16 GB RAM
- 20 GB free disk space
- Graphics: Dedicated GPU

---

## Troubleshooting

### Unity Hub won't open
- Right-click Unity Hub icon → Run as Administrator

### Can't find Unity 2022.3 LTS in Installs
- Click "Archive" tab in the install window
- Look under "LTS Releases"

### Visual Studio didn't install
- Go back to Unity Hub → Installs
- Click the 3 dots next to Unity 2022.3
- Click "Add Modules"
- Check "Microsoft Visual Studio Community"
- Click "Install"

### Unity is running slowly
- Close other programs
- Make sure you have at least 8 GB RAM
- Check Task Manager - Unity should use 1-3 GB

### Scripts won't compile
- This is normal at this stage
- We need to add Unity-specific files (next step)

---

## Quick Reference

**Unity Hub Location:**
`C:\Program Files\Unity Hub\Unity Hub.exe`

**Unity Editor Location:**
`C:\Program Files\Unity\Hub\Editor\2022.3.XX\Editor\Unity.exe`

**Visual Studio Location:**
`C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe`

**Your Project Location:**
`[Your Path]\HttK\`

---

**You're all set!** 🚀

Let me know when you've completed the installation and we'll continue with setting up the Unity project files!
