using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicagoSuburbGenerator {

    Dictionary<int , List<string>> nameLists = new Dictionary<int , List<string>>();

    public string currName;


    public void callFirst () {

        createLists();
        currName = makeName();
    }

    void createLists () {

        List<string> listA = new List<string>() { "Forest" , "Oak" , "Grove" , "Maple" };

        List<string> listB = new List<string>() { "Park" , "Lake" , "Ridge" , "Glen" , "Heights" , "Bluff" };

        List<string> listC = new List<string>() { "Morton" , "Myron" , "Vernon" , "Bartholomew" , "Barton" , "Quincy" , "Buffalo" , "Highland" };

        nameLists.Add( 0 , listA );
        nameLists.Add( 1 , listB );
        nameLists.Add( 2 , listC );

    }

    public string makeName () {

        int listNum1 = (int) Mathf.Floor( Random.Range( 0 , 3 ) );
        int listNum2 = (int) Mathf.Floor( Random.Range( 0 , 2 ) );

        int list1Count = nameLists[ listNum1 ].Count;
        int list2Count = nameLists[ listNum2 ].Count;

        string firstPart = nameLists[ listNum1 ][ (int) Mathf.Floor( Random.Range( 0 , list1Count ) ) ];

        string secondPart = nameLists[ listNum2 ][ (int) Mathf.Floor( Random.Range( 0 , list2Count ) ) ];

        return firstPart + " " + secondPart;
    }

}
