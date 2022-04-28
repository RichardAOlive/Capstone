# Capstone RTS
This repository contains all the info regarding my real time strategy game project using the unity engine and various unity features. The purpose of this game and it's creation is to simply provide a basic groundwork from which i can add new features or improve existing ones as i have the time and energy to do so.
 
 ## Table of Contents
 * [Download and Installation Instructions](https://github.com/RichardAOlive/Capstone#download-and-installation-instructions)
 * [Modeling Information](https://github.com/RichardAOlive/Capstone/tree/main/Modeling)
 * [Usage Instructions](https://github.com/RichardAOlive/Capstone#usage-instructions)
 * [Gameplay Demo](https://github.com/RichardAOlive/Capstone#gameplay-demo)
 * [Inline Code](https://github.com/RichardAOlive/Capstone#inline-code)
 * [Additonal Credits](https://github.com/RichardAOlive/Capstone#additonal-credits)
 * [Licensing Information](https://github.com/RichardAOlive/Capstone/blob/main/LICENSE)
 
 ## Download and Installation Instructions
 * Step 1. Download the project zip folder.
 * Step 2. Extract the project files into a folder of your choice.
 * Step 3. Open the project in Unity Hub and when it asks if you would like to fix anything click "Ignore".
 * Step 4. Once the project is open in unity go to the "Build Settings" and click "Build and Run". This will build the project into an executable file.
 * Step 5. Play the game. In the future if you with to all that needs to be done is run the Build executable to play the game from that current build. These steps need to be reapeated if and upadtes or changes are made to the latest build of the game.
 
 ## Usage Instructions
 ### Gameplay screen
 Currently the only screen implemented. Contains all the primary gameplay elements and is where the bulk of the code has taken place. The game can be played entirely with the mouse, though optionally the wasd keys can be used to move the camera around the screen.
 
 ## Gameplay Demo
 
 ## Inline Code
 Example code for spawning units.

 public class Spawner : MonoBehaviour
 {
     public GameObject Prefab;

     public void SpawnUnit()
     {
         Vector3 spawnpoint = transform.position;
         Vector3 spawnoffset = spawnpoint + new Vector3(5f, 0, 0);


         Instantiate(Prefab, spawnoffset, transform.rotation);
     }

     // Update is called once per frame
     public void OnMouseDown()
     {

         SpawnUnit();
     }
 }
 
 ## Additonal Credits
 While all of the work for the game has been done by myself below are links to various resources I found useful or informative whilst working on this project.
 * [Obsessive Games](https://www.youtube.com/channel/UCxZwx7ZYBUaXRqUPngBo3GA)
 * [Brackeys](https://www.youtube.com/c/Brackeys)
 * [TheScreamingFedora](https://www.youtube.com/c/TheScreamingFedora)
 * [xOctoManx](https://www.youtube.com/channel/UCjDiDU1hXq31QIr0vN_yacQ)
