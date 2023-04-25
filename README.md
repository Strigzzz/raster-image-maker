A simple Ratser image editor with SVG operations

I have implemented the following tools

Shape tools

//rectangle

//Elipse


Freeform tools

//Pencil

//Eraser


Utility tools
//Fill tool
//Color picker
//Clear image
//Size bar
//Undo(WIP)

the save button will allow you to name your file and save it to your computer (as of now this is only in Jpeg format)
![evidence1](https://user-images.githubusercontent.com/67929377/233766991-58f721ea-4036-40d5-b44e-aa938082d009.JPG)
![Evidence2](https://user-images.githubusercontent.com/67929377/233767010-70ab0dbf-3e07-47d9-9212-f4185427eecb.JPG)

Installed libraries are
//Newtonsoft.Json by James Newton-King
//Svg by davescriven, jvenema, mrbean-bremen, H1Gdev, Wiesław Šoltés, owaits, ddpruitt, Ralf1108, Tebjan Halm, and others


Bugs and known issues
//When using the fill tool to fill a black shape with black, the app will get stuck in a loop, eventually crashing. As a
  result i have removed the option to use black to fill a black shape, all other colors still work.
//Unideally the rectangle tool works only when the mouse is dragged to the right or down, and simply will not function
  in the other directions
//Undo button currently not working
//When the size is increased the pencil tool will become fuzzy when drawing diagonal, this is becuause it is a line of pixels
  that snaps only horizontally or vertically, problem extends to the eraser but it feels kind of fine for that tool, 
  still should be fixed

To-Do
//Finish undo button
//Figure a way to export in the SVG format (possibly use library to convert image instead)
