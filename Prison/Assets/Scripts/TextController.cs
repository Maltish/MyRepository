using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TextController : MonoBehaviour {

    enum States {  cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, corridor_0,stairs_0,floor,closet_door,corridor_1,stairs_1,in_closet,corridor_2,stairs_2,corridor_3,courtyard,death} 

    public Text myText;
    States myState;

    // Use this for initialization
    void Start () {
        //initialise myState to cell
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
        //check the current state
        if(myState == States.cell)                 { Cell(); }
        else if(myState == States.sheets_0)        { Sheets_0(); }
        else if (myState == States.mirror)         { Mirror(); }
        else if (myState == States.lock_0)         { Lock_0(); }
        else if (myState == States.cell_mirror)    { Cell_Mirror(); }
        else if (myState == States.sheets_1)       { Sheets_1(); }
        else if (myState == States.lock_1)         { Lock_1(); }
        else if (myState == States.corridor_0)     { Corridor_0(); }
        else if (myState == States.stairs_0)       { Stairs_0(); }
        else if (myState == States.floor)          { Floor(); }
        else if (myState == States.closet_door)    { Closet_Door(); }
        else if (myState == States.corridor_1)     { Corridor_1(); }
    }

    void Cell()
    {
        myText.text = "You are in a prison cell, and you want to escape." +
            "\nThere are some dirty sheets on the bed, a mirror on the wall, " +
            "\nand the door is locked from outside\n\n" +
            "Press S to view the sheets, M to view the mirror and L to view " +
            "the Lock.";
        if (Input.GetKeyDown(KeyCode.S))        {myState = States.sheets_0;}
        else if (Input.GetKeyDown(KeyCode.M))   { myState = States.mirror; }
        else if (Input.GetKeyDown(KeyCode.L))   { myState = States.lock_0; }
    }

    void Sheets_0()
    {
        myText.text = "These sheets are very dirty! I guess you would expect that" +
            "from a prison. Hopefully they are changed soon!" +
            "\n\nPress R to return back to the middle of the cell.";
        if(Input.GetKeyDown(KeyCode.R))             { myState = States.cell; }
    }

    void Lock_0()
    {
        myText.text = "This is one of those button lock. I have no idea what the combination is." +
            "You wish you could somehow see where the dirty fingerprints were." +
            "\n\nPress R to return back to the middle of the cell.";

        if (Input.GetKeyDown(KeyCode.R))            { myState = States.cell; }
    }
    void Mirror()
    {
        myText.text = "That dirty old mirror on the wall seems loose!" +
            "\n\n Press T to take the mirror, or R to return back to the middle of the cell.";

        if (Input.GetKeyDown(KeyCode.T))            { myState = States.cell_mirror; }
        else if (Input.GetKeyDown(KeyCode.R))       { myState = States.cell; }
    }
    void Cell_Mirror()
    {
        myText.text = "You are still in your cell and you STILL want to escape!" +
            "There are still some dirty sheets on the bed and the cell door which is firmly locked." +
            "\n\nPress S to view the sheets, L to view the lock.";

        if (Input.GetKeyDown(KeyCode.S))            { myState = States.sheets_1; }
        else if (Input.GetKeyDown(KeyCode.L))       { myState = States.lock_1; }
    }
    void Sheets_1()
    {
        myText.text = "Holding a mirror in your hand, won't make the sheets look any better and cleaner!" +
            "\n\nPress R to go back to the middle of the cell,";
        if (Input.GetKeyDown(KeyCode.R))            { myState = States.cell_mirror; }
    }
    void Lock_1()
    {
        myText.text = "You carefull put the mirror through the bars, and turn it round to see the lock." +
            "You can now see the fingerprints on the lock." +
            "You press the dirty buttons, and hear a click!" +
            "\n\nPress O to open, R to return back to the cell.";

        if (Input.GetKeyDown(KeyCode.O))            { myState = States.corridor_0; }
        else if (Input.GetKeyDown(KeyCode.R))       { myState = States.cell_mirror; }
    }
    void Corridor_0()
    {
        myText.text = "When you get out of your Prison Cell you realise " +
            "that you need to do more things to be truly free as you end up in the corridor." +
            "You can see stairs going up, a dirt floor and a closet door.\n\n" +
            "Press S to go up the stairs, F to search the dirty floor and C to go to the closet door.";

        if (Input.GetKeyDown(KeyCode.S))            { myState = States.stairs_0; }
        else if (Input.GetKeyDown(KeyCode.F))       { myState = States.floor; }
        else if (Input.GetKeyDown(KeyCode.C))       { myState = States.closet_door; }
    }
    void Stairs_0()
    {
        myText.text = "You start walking up the stairs towards the outside light. " +
            "You realise it's not break time, and you'll be caught immediately. " +
            "You slither back down the stairs and reconsider.\n\n" +
            "Press R to go back to the corridor";

        if(Input.GetKeyDown(KeyCode.R))             { myState = States.corridor_0; }
             


    }
    void Floor()
    {
        myText.text = "Rummaging around on the dirty floor, you find a hairclip.\n\n" +
            "Press T to take the hairclip";

        if(Input.GetKeyDown(KeyCode.T))             { myState = States.corridor_1; }
    }

    void Closet_Door()
    {
        myText.text = "You are looking at a closet door, unfortunately it's locked. " +
        "Maybe you could find something around to help enourage it open?\n\n" +
        "Press R to return to the corridor.";
        if (Input.GetKeyDown(KeyCode.R))            { myState = States.corridor_0; }
    }
    void Corridor_1()
    {
        myText.text = "Still in the corridor. Floor still dirty. Hairclip in hand. " +
        "Now what? You wonder if that lock on the closet would succumb to " +
        "to some lock-picking?\n\n" +
        "Press S to go up the stairs, C to go to the closet";
        if (Input.GetKeyDown(KeyCode.S))            { myState = States.stairs_1; }
        else if (Input.GetKeyDown(KeyCode.C))       { myState = States.in_closet; }
    }
    void Stairs_1()
    {
        myText.text = "Unfortunately wielding a puny hairclip hasn't given you the " +
        "confidence to walk out into a courtyard surrounded by armed guards!\n\n" +
        "Press R to return to the corridor.";
        if (Input.GetKeyDown(KeyCode.R))            { myState = States.corridor_1; }

    }
    void In_Closet()
    {
        myText.text = "Inside the closet you see a cleaner's uniform that looks about your size! " +
           "Seems like your day is looking-up.\n\n";

    }
}
