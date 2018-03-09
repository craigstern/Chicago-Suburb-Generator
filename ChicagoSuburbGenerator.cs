using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicagoSuburbGenerator {

    Dictionary<int , List<string>> nameLists = new Dictionary<int , List<string>>();

    public string currName;

    //we'll need to call this on initialization to fill up nameLists and get our first name in currName
    public void callFirst () {

        createLists();
        makeName();
    }

    //here's where we fill up nameLists
    void createLists () {

        //tree-related words
        List<string> listA = new List<string>() { "Forest" , "Oak" , "Grove" , "Maple" };

        //assorted geographical features
        List<string> listB = new List<string>() { "Park" , "Lake" , "Ridge" , "Glen" , "Heights" , "Bluff" };

        //dorky-sounding names and misc.
        List<string> listC = new List<string>() { "Morton" , "Myron" , "Vernon" , "Bartholomew" , "Barton" , "Quincy" , "Buffalo" , "Highland" };

        nameLists.Add( 0 , listA );
        nameLists.Add( 1 , listB );
        nameLists.Add( 2 , listC );

    }

    //and here's where we actually cobble together a new name, then stick it in currName
    public string makeName () {

        int listNum1 = (int) Mathf.Floor( Random.Range( 0 , 3 ) );  //pick any list for the first part
        int listNum2 = (int) Mathf.Floor( Random.Range( 0 , 2 ) );  //pick only lists A or B for the second

        int list1Count = nameLists[ listNum1 ].Count;
        int list2Count = nameLists[ listNum2 ].Count;

        string firstPart = nameLists[ listNum1 ][ (int) Mathf.Floor( Random.Range( 0 , list1Count ) ) ];    //pull a string at random from the first list
        string secondPart = nameLists[ listNum2 ][ (int) Mathf.Floor( Random.Range( 0 , list2Count ) ) ];   //pull a string at random from the second list

        currName = firstPart + " " + secondPart;
        
        return currname;
    }

}
