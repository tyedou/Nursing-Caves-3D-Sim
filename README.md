#Description


  Virtual Nursing Skills Lab (CAVE) is an immersive 3D training experience built in Unity for large-scale, multi-wall immersive environments. The project simulates a hospital wardroom where users can explore a realistic clinical space and interact with medical assets in a room-scale setting, designed to support nursing education and experiential learning.

The experience is built using the Immersive Interactive SDK, allowing the scene to be rendered across multiple physical surfaces (Left, Centre, Right, Back, and optional Floor) to create the feeling of standing inside the room itself. Users can navigate the environment using a virtual room simulator during development, or experience the full projection-mapped version inside an immersive lab.

Care has been taken to ensure proper real-world scale, camera alignment, and surface mapping so that objects appear consistent and believable across walls. The project is intended as a foundation for future interactive scenarios such as patient assessment, equipment familiarization, and procedural walkthroughs.

If you would like to view or modify the Unity project files, please see the Installation section below.
If you would like to run the experience inside an immersive environment, please see the Usage section for build and runtime instructions.

#Installation

To access and edit the project files, you will need Unity Hub, the Unity Editor, and the Immersive Interactive SDK. The following instructions outline the basic setup process.

Install Unity Hub and Unity Editor

Go to https://unity.com/download
.
Download and install Unity Hub.
Open Unity Hub and sign in with a Unity account.

If you do not have an account, create one and follow Unity’s recommended security steps.

In Unity Hub, go to the Installs tab and install a supported version of the Unity Editor.

This project uses the Built-in Render Pipeline, so no additional render pipeline packages are required.
Open the Project
Clone or download this repository to your local machine.
Open Unity Hub.
Click Open and select the root folder of the project.
Unity will load the project and import all assets. This may take a few minutes on first launch.

Immersive SDK Setup

Ensure the Immersive Interactive SDK is installed and properly imported into the project.

Open the main scene included in the repository.

Verify that the following objects exist in the scene:

ImmersiveManager

UI System

Stage

Use the Simulator Settings in the Unity Editor to preview the experience in a virtual room during development.

Running the Experience in an Immersive Room

To run the project inside an immersive environment:

Build the project using File → Build Settings → Build.

Navigate to the generated Run Shortcuts folder in the build directory.

Launch the application using the appropriate .bat file that matches the physical room layout (e.g., Walls, All Walls, or Walls with Floor).

Start Immersive Interactive and ensure it is configured to capture the running application.

Once launched correctly, the experience will render across the immersive room surfaces.
