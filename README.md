# Camera Follow Script for Unity

This is a simple, customizable script for Unity 2D that will make a Camera follow an assigned object. This is designed for 2D Player Movement, but it can be used for anything else.

### How to use it
1. Attach "Camera.cs" to the Camera object.
2. Set the "Player" transform variable to the player object or whatever you want the camera to follow.
3. Adjust the speed if needed, and enjoy!

### Key Features
- The Camera will **stop following** when the Y axis = 0, but this can be adjusted.
- It uses the **Slerp()** function for smoothness.
