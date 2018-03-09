using System.Collections.Generic;
using System;

public class ChicagoSuburbGenerator {

    //we'll need to call this on initialization to fill up nameLists and get our first name in currName
    public void Main () {
		var seed = createLists(); 
		
        Console.Write(makeName(seed));
    }

    //here's where we fill up nameLists
    List<List<string>> createLists () {

        //tree-related words
		return new List<List<string>> {	
			//trees
			new List<string>() { "Forest" , "Oak" , "Grove" , "Maple" } ,
			//geographic
				new List<string>() { "Park", "Lake" , "Ridge" , "Brook" , "River" , "Field" , "Glen" , "Heights" , "Hills" , "Meadows" , "Bluff" },
			//old-timey names and misc.
			new List<string>() { "Bartholomew" , "Barton" , "Downers" , "Grays" , "Lincoln" , "Morton" , "Morgan" , "Myron" , "Quincy" , "Tinley" , "Vernon" , "Buffalo" , "Deer" , "Highland" , "Orland" } };
	}

    //and here's where we actually cobble together a new name, then stick it in currName
    public string makeName (List<List<string>> seed) {
		var rnd = new Random();
		
		var secondSeed = rnd.Next(2); 
		var temp = new List<int>() {2, Math.Abs(secondSeed-1)};
		
		var list1 = seed[temp[rnd.Next(2)]];
		var list2 = seed[secondSeed]; 
		
		return String.Format("{0} {1}", list1[rnd.Next(list1.Count)],  list2[rnd.Next(list2.Count)]);  
    }

}
