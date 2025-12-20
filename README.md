##Description##


  Virtual Nursing Skills Lab (CAVE) is an immersive 3D training experience built in Unity for large-scale, multi-wall immersive environments. The project simulates a hospital wardroom where users can explore a realistic clinical space as in a room-scale setting, designed to support nursing education and experiential learning.

The experience is built using the Immersive Interactive SDK, allowing the scene to be rendered across multiple physical surfaces (Left, Centre, Right, Back, and optional Floor) to create the feeling of standing inside the room itself. Users can navigate the environment using a virtual room simulator during development, or experience the full projection-mapped version inside an immersive lab.

If you would like to view or modify the Unity project files, please see the Installation section below.
If you would like to run the experience inside an immersive environment, please see the Usage section for build and runtime instructions.

##Installation##

  To access and edit the project files, you will need Unity Hub, the Unity Editor, and the Immersive Interactive SDK. The following instructions outline the basic setup process.

Install Unity Hub and Unity Editor

Go to https://unity.com/download
Download and install Unity Hub.
Open Unity Hub and sign in with a Unity account.
If you do not have an account, create one

In Unity Hub, go to the Installs tab and install a supported version of the Unity Editor for the SDK, specifically 2021.3.X

Open the Project
Clone or download this repository to your local machine.
Open Unity Hub.
Click Open and select the root folder of the project.
Unity will load the project and import all assets. This may take a few minutes on first launch.

Immersive SDK Setup

  Ensure the Immersive Interactive SDK is installed and properly imported into the project.

Open the main scene included in the repository.

Verify that the following objects exist in the scene:

ImmersiveManager,
UI System,
Stage

  Running the Experience in an Immersive Room

To run the project inside an immersive environment:

Test the project. Press the play button at the top of the editor to be taken to a in-built simulator provided by the SDK
Build the project using File → Build Settings → Build.
Navigate to the generated Run Shortcuts folder in the build directory.
Launch the application using the appropriate .bat file that matches the physical room layout (e.g., Walls, All Walls, or Walls with Floor).
This will run a snapshot of what it looks like to run the immersive experience in the physical room.
Once launched correctly within the physical room, the experience will render across the immersive room surfaces.

##Visuals##


<img width="900" height="600" alt="image" src="https://github.com/user-attachments/assets/89ea53ff-157e-4241-8b43-7f009aadd346" />

<img width="900" height="600" alt="image" src="https://github.com/user-attachments/assets/d5b42746-c607-4d12-a51c-808367af4eb2" />

<img width="900" height="600" alt="image" src="https://github.com/user-attachments/assets/c0a475e0-ac91-4eef-bec9-21f997523549" />

##Future Improvements##
While the current experience demonstrates the core immersive setup and interaction pipeline, there are several areas where the project can be expanded to improve realism, engagement, and training depth.

One major area for improvement is the overall liveliness of the scene. At present, the experience includes a single character holding an interactive element as a proof of concept. Adding additional character animations, idle behaviors, contextual menus, and multiple scenes would make the environment feel more active and engaging while standing inside the immersive room.
